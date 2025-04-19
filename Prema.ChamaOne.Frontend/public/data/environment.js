// Environment configuration that can be modified after build
// Defines configuration values on the global window.__ENV object

(function(window) {
    window.__ENV = window.__ENV || {};
    
    // Application environment
    window.__ENV.production = false;
    
    // API and base URLs
    window.__ENV.apiUrl = 'http://localhost:8123/api';
    window.__ENV.baseUrl = 'http://localhost:4200';
    window.__ENV.useHash = false;
    
    // Keycloak configuration
    window.__ENV.keycloakUrl = 'https://keycloak-dev.prema.co.ke';
    window.__ENV.keycloakRealm = 'chama-one';
    window.__ENV.keycloakClient = 'public-client';
    
    // Other settings
    window.__ENV.websiteUrl = 'https://fintrack.shangilia.africa/';
    window.__ENV.contactNumber = '0712490863';
    
  })(this);