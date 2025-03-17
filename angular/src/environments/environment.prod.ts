import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44315/',
  redirectUri: baseUrl,
  clientId: 'TotalStore_App',
  responseType: 'code',
  scope: 'offline_access TotalStore',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TotalStore',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44315',
      rootNamespace: 'TotalStore',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
