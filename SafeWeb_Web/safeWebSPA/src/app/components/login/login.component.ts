import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl, Validators } from "@angular/forms";
import { Login } from "src/app/models/login/login.model";
import { AuthenticationService } from "src/app/services/autentication/authentication.service";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

    loginForm: FormGroup;

    constructor(private authenticationService: AuthenticationService) { }

    ngOnInit(): void {
        this.formInitialize();
    }

    formInitialize(): void {
        this.loginForm = new FormGroup({
            email: new FormControl('', [Validators.required]),
            password: new FormControl('', [Validators.required]),
            remember: new FormControl(false)
        })
    }

    onSubmit() {
        this.loginValidate();
    }

    loginValidate = (): void => {
        return this.constructObject(this.loginForm, this.sendObject)
    }

    constructObject = (form: FormGroup, method): void => {
        let login = new Login(form.value.email, form.value.password);
        return method(login);
    }

    sendObject = (obj: any): void => {
        this.authenticationService.validarLogin(obj)

    }


}