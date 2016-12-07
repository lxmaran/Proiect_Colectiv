import { Aurelia, inject } from 'aurelia-framework';
import { HttpClient } from 'aurelia-http-client';
@
inject(Aurelia, HttpClient)

export default class AuthService {

    session = null

    constructor(Aurelia, HttpClient) {
        HttpClient.configure(http => {
//            http.withBaseUrl(config.baseUrl);
        });

        this.http = HttpClient;
        this.app = Aurelia;

//        this.session = JSON.parse(localStorage[config.tokenName] || null);
    }

    login(username, password) {
//        this.http
//        	.post(config.loginUrl, { username, password })
//        	.then((response) => response.content)
//        	.then((session) => {

//        	    localStorage[config.tokenName] = JSON.stringify(session);

//        	    this.session = session;

        this.app.setRoot('app');
//        	});
    }

    logout() {

//        localStorage[config.tokenName] = null;

//        this.session = null;

        this.app.setRoot('/login');
    }

    isAuthenticated() {
        return this.session !== null;
    }

    can(permission) {
        return true;
    }
}