import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { Login } from "src/app/models/login/login.model";
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class AuthenticationService {

    url: string;

    constructor(private http: HttpClient, private readonly router: Router) {
        this.url = environment.server;
    }

    validarLogin = (login: Login) => {
        let action = environment.login;
        let url = ` ${this.url + action}`;
        return this.http.post(url, login, { responseType: 'text' }).subscribe(data => {
            this.criarSessionStorage(data);
            this.router.navigate(["/home"]);
        }, error => {
            console.log(error);
            alert(error.error);
        });
    }

    criarSessionStorage(user: any) {
        let key = "userSession";
        sessionStorage.setItem(key, JSON.stringify(user));
        console.log(JSON.stringify(user));
    }

}