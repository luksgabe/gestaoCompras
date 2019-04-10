import { Component, OnInit } from "@angular/core";
import { Usuario } from "src/app/models/usuario.model";
import { ActivatedRoute, Params } from "@angular/router";
import { UsuarioService } from "src/app/services/home/usuario.service";

@Component({
    selector: 'app-usuario-detalhe',
    templateUrl: './usuario-detalhe.component.html',
    styleUrls: ['./usuario-detalhe.component.scss']
})
export class UsuarioDetalheComponent implements OnInit {

    usuario: Usuario = new Usuario();
    idUsuarioParam: number;


    constructor(private route: ActivatedRoute, private usuarioService: UsuarioService) {
    }

    ngOnInit(): void {
        this.checkUsuario();
    }


    checkUsuario = (): void => {
        this.route.params.forEach((params: Params) => {
            this.idUsuarioParam = +params['id']
        })

        if (this.idUsuarioParam) {
            this.usuarioService.getUsuarios().subscribe(users => {
                this.usuario = users.find(usuario => {
                    return usuario.id === this.idUsuarioParam;
                });
            })
            console.log(this.usuario)
        }
    }


    onSubmit = (): void => {
        this.salvarUsuario();
    }

    salvarUsuario = () => {
        this.usuarioService.postUsuario(this.usuario).subscribe(() => {
            if (this.idUsuarioParam)
                alert("Usuário salvo com sucesso")
            else
                alert("Usuário alterado com sucesso")
        }, error => {
            console.log(error);
            alert(error.error);
        });
    }


}