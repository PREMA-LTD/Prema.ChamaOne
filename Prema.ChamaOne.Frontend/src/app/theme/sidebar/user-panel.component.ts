import { Component, OnInit, ViewEncapsulation, inject } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';
import { TranslateModule } from '@ngx-translate/core';
import { KeycloakService } from 'keycloak-angular';
import { KeycloakProfile } from 'keycloak-js';

@Component({
  selector: 'app-user-panel',
  template: `
    <div class="matero-user-panel" routerLink="/profile/overview">
      <div class="matero-user-panel-info">
        <h4>{{ user?.firstName }} {{ user?.lastName }}</h4>
        <h5>{{ user?.username }}</h5>
      </div>
    </div>
  `,
  styleUrls: ['./user-panel.component.scss'],
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [RouterLink, MatButtonModule, MatIconModule, MatTooltipModule, TranslateModule],
})
export class UserPanelComponent implements OnInit {
  private readonly auth = inject(KeycloakService);

  user?: KeycloakProfile; // Change to optional property

  async ngOnInit(): Promise<void> {
    const isAuthenticated = await this.auth.isLoggedIn();

    console.log("user panel: "+isAuthenticated);

    try {
      this.user = await this.auth.loadUserProfile();
      // Continue with setting permissions
    } catch (error) {
      console.error('Failed to load user profile', error);
      // Handle the error (e.g., show an error message to the user)
    }
  }
}
