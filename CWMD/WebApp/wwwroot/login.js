import { inject } from 'aurelia-framework';
import AuthService from 'modules/login-module/AuthService';

@inject(AuthService)
export class Login {

    constructor(AuthService) {

        this.login = () => {
            if (this.username && this.password) {
                AuthService.login(this.username, this.password);
            } else {
                this.error = 'Please enter a username and password.';
            }
        }
    }

    activate() {
        this.username = '';
        this.password = '';
        this.error = '';
    }
}