import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Usuario } from "src/app/models/usuario.model";
import { Observable, empty } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class UsuarioService {

    url: string;
    usuario: Usuario;
    listaUsuarios: Array<Usuario>;


    constructor(private http: HttpClient) {
        this.url = environment.server;
    }

    public getUsuarios = (): Observable<Usuario[]> => {
        let url = `${this.url + environment.home.usuarioLista}`;
        return this.http.get<Usuario[]>(url)
    }

    public postUsuario = (usuario: Usuario): Observable<Usuario> => {
        let url = `${this.url + environment.home.usuario}`;
        return this.http.post<Usuario>(url, usuario)
    }
}