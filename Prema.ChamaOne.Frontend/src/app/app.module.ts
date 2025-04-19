import { APP_INITIALIZER, NgModule } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

import { AppComponent } from './app.component';

import { CoreModule } from '@core/core.module';
import { ThemeModule } from '@theme/theme.module';
import { SharedModule } from '@shared/shared.module';
import { RoutesModule } from './routes/routes.module';
import { FormlyConfigModule } from './formly-config.module';
import { NgxPermissionsModule } from 'ngx-permissions';
import { ToastrModule } from 'ngx-toastr';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';

import { environment } from '@env/environment';
import { BASE_URL, httpInterceptorProviders, appInitializerProviders } from '@core';

import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';

// Required for AOT compilation
export function TranslateHttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http, 'i18n/', '.json');
}

import { LoginService } from '@core/authentication/login.service';
import { FakeLoginService } from './fake-login.service';
import { KeycloakAngularModule, KeycloakService } from 'keycloak-angular';

export function initializeKeycloak(keycloak: KeycloakService) {
  console.log("initializeKeycloak");
  return () =>
    keycloak.init({
      config: {
        url: environment.keycloakUrl,
        realm: environment.keycloakRealm,
        clientId: environment.keycloakClient
      },
      loadUserProfileAtStartUp: true,
      initOptions: {
        onLoad: 'login-required', // Can be 'check-sso' for SSO
        checkLoginIframe: false,
      },
      bearerExcludedUrls: ['/assets'], // Exclude certain URLs from Keycloak's token check
    });
}

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    CoreModule,
    ThemeModule,
    SharedModule,
    RoutesModule,
    KeycloakAngularModule,
    FormlyConfigModule.forRoot(),
    NgxPermissionsModule.forRoot(),
    ToastrModule.forRoot(),
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: TranslateHttpLoaderFactory,
        deps: [HttpClient],
      },
    }),
  ],
  providers: [
    provideAnimationsAsync(),
    { provide: BASE_URL, useValue: environment.baseUrl },
    // ==================================================
    // 👇 ❌ Remove it in the realworld application
    //
    // { provide: LoginService, useClass: FakeLoginService },
    // { provide: LoginService, useClass: LoginService },
    //
    // ==================================================
    ...httpInterceptorProviders,
    // {
    //   provide: APP_INITIALIZER,
    //   useFactory: initializeKeycloak,
    //   multi: true,
    //   deps: [KeycloakService],
    // },
    ...appInitializerProviders,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
