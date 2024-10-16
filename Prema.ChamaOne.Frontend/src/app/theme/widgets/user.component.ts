import { ChangeDetectorRef, Component, OnInit, inject } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { Router, RouterLink } from '@angular/router';
import { TranslateModule } from '@ngx-translate/core';
import { debounceTime, tap } from 'rxjs';

import { AuthService, SettingsService, User } from '@core';
import { KeycloakService } from 'keycloak-angular';
import { KeycloakProfile } from 'keycloak-js';
import { environment } from '@env/environment';
import { MemberFormComponent } from 'app/routes/members/member-form/member-form.component';
import { MembersService, Member } from 'app/routes/members/members.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-user',
  template: `
<button mat-icon-button [matMenuTriggerFor]="menu">
  <mat-icon>person</mat-icon>
</button>


    <mat-menu #menu="matMenu">
     <!-- <button routerLink="/profile/overview" mat-menu-item>
        <mat-icon>account_circle</mat-icon>
        <span>{{ 'profile' | translate }}</span>
      </button>
      <button mat-menu-item (click)="restore()">
        <mat-icon>restore</mat-icon>
        <span>{{ 'restore_defaults' | translate }}</span>
      </button> -->
      <button mat-menu-item (click)="openEditProfileDialog()">
        <mat-icon>edit</mat-icon>
        <span>{{ 'edit_profile' | translate }}</span>
      </button>
      <button mat-menu-item (click)="logout()">
        <mat-icon>exit_to_app</mat-icon>
        <span>{{ 'logout' | translate }}</span>
      </button>
    </mat-menu>
  `,
  styles: `
    .avatar {
      width: 1.5rem;
      height: 1.5rem;
      border-radius: 50rem;
    }
  `,
  standalone: true,
  imports: [RouterLink, MatButtonModule, MatIconModule, MatMenuModule, TranslateModule],
  providers: [MembersService]
})
export class UserComponent implements OnInit {

  constructor(public dialog: MatDialog) {}
  
  private readonly cdr = inject(ChangeDetectorRef);
  private readonly auth = inject(KeycloakService);
  private readonly router = inject(Router);
  private readonly settings = inject(SettingsService);
  private readonly membersService = inject(MembersService);

  user!: KeycloakProfile;

  async ngOnInit(): Promise<void> {
    try {
      this.user = await this.auth.loadUserProfile();
    } catch (error) {
      console.error('Failed to load user profile', error);
      // Handle the error (e.g., show an error message to the user)
    }
  }

  async logout() {
    // this.auth.logout().subscribe(() => {
    //   this.router.navigateByUrl('/auth/login');
    // });

    await this.auth.logout(environment.baseUrl);
  }

  restore() {
    this.settings.reset();
    window.location.reload();
  }

  async openEditProfileDialog() {
    const keycloakProfile: KeycloakProfile | undefined = await this.auth.loadUserProfile();
    const memberId: any | null = keycloakProfile?.attributes?.['memberId'] ? keycloakProfile.attributes['memberId'] : null;   
    this.membersService.getMembersById(memberId).subscribe((memberData: Member) => {
    const dialogRef = this.dialog.open(MemberFormComponent, {
      maxWidth: '90vw',
      width: '500px',
      maxHeight: '90vh',
      height: 'auto',
      panelClass: 'app/routes/members/members/members.component.scss',
      disableClose: true,
      autoFocus: true,
      data: { memberData }// Pass the user data to the dialog
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        // Handle the result from the dialog (e.g., update user profile)
        console.log('The dialog was closed', result);
      }
    });
    });

  }
}
