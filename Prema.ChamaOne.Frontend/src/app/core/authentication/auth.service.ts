import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, catchError, iif, map, merge, of, share, switchMap, tap } from 'rxjs';
import { filterObject, isEmptyObject } from './helpers';
import { User } from './interface';
import { LoginService } from './login.service';
import { TokenService } from './token.service';
import { KeycloakService } from './keycloak.service';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private readonly loginService = inject(LoginService);
  private readonly keycloakService = inject(KeycloakService);
  private readonly tokenService = inject(TokenService);

  private user$ = new BehaviorSubject<User>({});
  // private change$ = merge(
  //   this.tokenService.change(),
  //   this.tokenService.refresh().pipe(switchMap(() => this.refresh()))
  // ).pipe(
  //   switchMap(() => this.assignUser()),
  //   share()
  // );

  private change$ = merge(
    this.tokenService.change(),
    this.tokenService.refresh().pipe(switchMap(() => this.refresh()))
  ).pipe(
    share()
  );
  

  init() {
    return new Promise<void>(resolve => this.change$.subscribe(() => resolve()));
  }

  change() {
    return this.change$;
  }

  check() {
    // return this.keycloakService.keycloak.authenticated ?? true;
    return this.tokenService.valid();
  }

  login(username: string, password: string, rememberMe = false) {
    return this.loginService.login(username, password, rememberMe).pipe(
      tap(token => this.tokenService.set(token)),
      map(() => this.check())
    );
  }

  refresh() {
    return this.loginService
      .refresh(filterObject({ refresh_token: this.tokenService.getRefreshToken() }))
      .pipe(
        catchError(() => of(undefined)),
        tap(token => this.tokenService.set(token)),
        map(() => this.check())
      );
  }

  logout() {
    return this.loginService.logout().pipe(
      tap(() => this.tokenService.clear()),
      map(() => !this.check())
    );
  }

  user() {
    return this.user$.pipe(share());
  }

  menu() {
    return iif(() => true, this.loginService.menu(), of([]));
  }

  private assignUser() {
    if (!this.check()) {
      return of({}).pipe(tap(user => this.user$.next(user)));
    }

    if (!isEmptyObject(this.user$.getValue())) {
      return of(this.user$.getValue());
    }

    return this.loginService.me().pipe(tap(user => this.user$.next(user)));
  }
}
