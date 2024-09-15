import { Injectable, inject } from '@angular/core';
import { AuthService, User } from '@core/authentication';
import { NgxPermissionsService, NgxRolesService } from 'ngx-permissions';
import { switchMap, tap } from 'rxjs';
import { Menu, MenuService } from './menu.service';
import { KeycloakAngularModule, KeycloakService } from 'keycloak-angular';
import { KeycloakProfile } from 'keycloak-js';

@Injectable({
  providedIn: 'root',
})
export class StartupService {
  private readonly authService = inject(AuthService);
  private readonly menuService = inject(MenuService);
  private readonly keycloakService = inject(KeycloakService);
  private readonly permissionsService = inject(NgxPermissionsService);
  private readonly rolesService = inject(NgxRolesService);

  // async load(): Promise<void> {
  //   return new Promise<void>(async (resolve, reject) => {
  //     console.log('StartupService load');
  //     try {
  //       const isLoggedIn = await this.keycloakService.isLoggedIn();
  //       console.log("loggedIn? " + isLoggedIn);

  //       if (isLoggedIn) {
  //         const user = await this.keycloakService.loadUserProfile();
  //         console.log("user: " + JSON.stringify(user));
          
  //         if (user) {
  //           await this.setPermissions(user);
  //           await this.loadMenu();
  //         } else {
  //           console.error('User profile is null even though user is logged in');
  //         }
  //       } else {
  //         console.log('User is not authenticated.');
  //       }
  //       resolve();
  //     } catch (error) {
  //       console.error('Error in StartupService load:', error);
  //       reject(error);
  //     }
  //   });
  // }

  load() {
    return new Promise<void>((resolve, reject) => {
      this.authService
        .change()
        .pipe(
          tap(user => this.setPermissions(user)),
          switchMap(() => this.authService.menu()),
          tap(menu => this.setMenu(menu))
        )
        .subscribe({
          next: () => resolve(),
          error: () => resolve(),
        });
    });
  }


  private async loadMenu(): Promise<void> {
    return new Promise<void>((resolve, reject) => {
      this.authService.menu().subscribe({
        next: menu => {
          this.setMenu(menu);
          resolve();
        },
        error: err => {
          console.error('Error fetching menu:', err);
          reject(err);
        },
      });
    });
  }

  private setMenu(menu: Menu[]) {
    console.log("set menu: " + JSON.stringify(menu)); 
    this.menuService.addNamespace(menu, 'menu');
    this.menuService.set(menu);
  }

  private async setPermissions(user: KeycloakProfile) {
    console.log("setting permisions")
    // In a real app, you should get permissions and roles from the user information.
    const roles = this.keycloakService.getUserRoles();
    
    const permissions = ['canAdd', 'canDelete', 'canEdit', 'canRead'];
    this.permissionsService.loadPermissions(permissions);
    this.rolesService.flushRoles();
    // this.rolesService.addRoles({ roles: permissions });
    roles.forEach(role => {
      this.rolesService.addRoles({
        [role]: permissions
      });
    });
  }
}