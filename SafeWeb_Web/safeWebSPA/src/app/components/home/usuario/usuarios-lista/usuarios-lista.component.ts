import { Component, OnInit } from "@angular/core";
import { Usuario } from "src/app/models/usuario.model";
import { UsuarioService } from "src/app/services/home/usuario.service";
import { Observable } from "rxjs";

@Component({
    selector: 'app-usuarios-lista',
    templateUrl: './usuarios-lista.component.html',
    styleUrls: ['./usuarios-lista.component.scss'],
    providers: [UsuarioService]
})
export class UsuariosListaComponent implements OnInit {

    listaUsuarios: Array<Usuario> = [];


    constructor(private readonly usuarioService: UsuarioService) {
    }


    ngOnInit(): void {
        this.listarUsuarios();
    }

    listarUsuarios = (): Promise<Usuario[]> => {
        this.usuarioService.getUsuarios().subscribe(usuarios => {
            this.listaUsuarios = usuarios;
            console.log(this.listaUsuarios);
        }, error => {
            console.log(error);
            return Promise.reject(error)
        });
        return Promise.resolve(this.listaUsuarios);
    }
}