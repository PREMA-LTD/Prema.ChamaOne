// This file loads environment configuration from the public/data/environment.js file
// The environment.js file is expected to define a global window.__ENV object

// Interface for environment configuration
export interface EnvironmentConfig {
  production: boolean;
  apiUrl: string;
  baseUrl: string;
  useHash: boolean;
  keycloakUrl: string;
  keycloakRealm: string;
  websiteUrl: string;
  contactNumber: string;
  keycloakClient: string;
}

// Default configuration (fallback values if environment.js fails to load)
const defaultConfig: EnvironmentConfig = {
  production: true,
  apiUrl: 'https://fintrack-backend.shangilia.africa/api' ,//'https://fintrack-backend.shangilia.africa/api',
  baseUrl: 'https://fintrack.shangilia.africa', //'https://fintrack.shangilia.africa',
  useHash: false,
  keycloakUrl: 'https://keycloak-prod.prema.co.ke',
  keycloakRealm: 'chama-one',
  websiteUrl: 'https://fintrack.shangilia.africa/',//'https://fintrack.shangilia.africa/',
  contactNumber: '0712490863',
  keycloakClient: 'public-client'
};

/**
 * Get the environment configuration from window.__ENV or use defaults
 */
function getEnvironmentConfig(): EnvironmentConfig {
  // Check if we're in a browser environment
  if (typeof window !== 'undefined') {
    // Access the global environment variables
    const envConfig = (window as any).__ENV;
    
    // If environment.js was loaded successfully, merge with defaults
    if (envConfig) {
      return { ...defaultConfig, ...envConfig };
    }
  }
  
  // Fallback to default configuration
  console.warn('Environment configuration not found, using default values');
  return defaultConfig;
}

// Export the environment configuration
export const environment = getEnvironmentConfig();