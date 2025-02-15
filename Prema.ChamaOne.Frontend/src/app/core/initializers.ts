import { APP_INITIALIZER } from '@angular/core';
import { KeycloakService } from 'keycloak-angular';
import { TranslateLangService } from './bootstrap/translate-lang.service';
import { StartupService } from './bootstrap/startup.service';
import { environment } from '@env/environment';

export function initializeApp(keycloak: KeycloakService, startupService: StartupService) {
  return () => new Promise<any>((resolve, reject) => {
    keycloak.init({
      config: {
        url: environment.keycloakUrl,
        realm: 'chama-one',
        clientId: 'public-client',
      },
      initOptions: {
        onLoad: 'login-required',
        checkLoginIframe: false,
      },
      loadUserProfileAtStartUp: true,
      bearerExcludedUrls: ['/assets'],
    })
    .then(() => {
      console.log('Keycloak initialized successfully');
      return startupService.load();
    })
    .then(() => {
      console.log('StartupService loaded successfully');
      resolve(true);
    })
    .catch((error) => {
      console.error('Error during initialization', error);
      reject(error);
    });
  });
}
export function TranslateLangServiceFactory(translateLangService: TranslateLangService) {
  return () => translateLangService.load();
}

export function StartupServiceFactory(startupService: StartupService) {
  return () => startupService.load();
}

export const appInitializerProviders = [
  {
    provide: APP_INITIALIZER,
    useFactory: initializeApp,
    multi: true,
    deps: [KeycloakService, StartupService]
  },
  {
    provide: APP_INITIALIZER,
    useFactory: TranslateLangServiceFactory,
    deps: [TranslateLangService],
    multi: true,
  },
  // {
  //   provide: APP_INITIALIZER,
  //   useFactory: StartupServiceFactory,
  //   deps: [StartupService],
  //   multi: true,
  // },
];

