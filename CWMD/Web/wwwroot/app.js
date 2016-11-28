import {HttpClient, json} from 'aurelia-fetch-client';

let httpClient = new HttpClient();

export class App 
{
    constructor()
    {
        this.email = '';
        this.password = '';
    }


    signIn() 
    {
        var user = {userName: this.email, password: this.password };
        console.log(user);
        this.postData(user);
    };

    postData(postData) 
    {
        httpClient.fetch('http://localhost:50776/api/users/signin', {
            method: "POST",            
            body: JSON.stringify(postData),          
            headers: {
                "content-type": "application/json",
                "origin": "http://localhost:52429/"
            },
        })
		
        .then(response => response.json())
        .then(data => {

        });
    };
}