const ENV = {
  dev: {
        apiUrl: 'http://localhost:44311',
    oAuthConfig: {
        issuer: 'http://localhost:44311',
        clientId: 'PowerBi_App',
      clientSecret: '1q2w3e*',
        scope: 'offline_access PowerBi',
    },
    localization: {
        defaultResourceName: 'PowerBi',
    },
  },
  prod: {
      apiUrl: 'http://localhost:44311',
    oAuthConfig: {
        issuer: 'http://localhost:44311',
        clientId: 'PowerBi_App',
      clientSecret: '1q2w3e*',
        scope: 'offline_access PowerBi',
    },
    localization: {
        defaultResourceName: 'PowerBi',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
