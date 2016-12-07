/// <reference path="modules/login-module/authservice.js" />
import AuthService from 'modules/login-module/AuthService';

export function configure(aurelia) {
    aurelia.use
        .standardConfiguration();

    aurelia.start().then(() => {
        var auth = aurelia.container.get(AuthService);
        let root = auth.isAuthenticated() ? () => { 'app' } : 'login';
        aurelia.setRoot(root);
    });
}