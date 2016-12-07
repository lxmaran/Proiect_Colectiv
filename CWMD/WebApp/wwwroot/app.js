import { inject } from 'aurelia-framework'; 
import AuthService from 'modules/login-module/AuthService';

@inject(AuthService)
export class App {

    configureRouter(config, router) {
        this.router = router;

        config.map([
            //set nav:true to be able to get the naviogation link into router.navigation and pasrse and use it in the app.html/nav-bar
            { route: "", moduleId: "app", title: "App", nav: true, name: "App" },
            { route: "home", moduleId: "modules/HelloRoute", title: "Hello", nav: true, name: "Home" }
        ]);
    }

    constructor(AuthService) {
        this.auth = AuthService;
    }
}

export class ToJSONValueConverter {
    toView(obj) {
        if (obj) {
            return JSON.stringify(obj, null, 2);
        }
    }
}