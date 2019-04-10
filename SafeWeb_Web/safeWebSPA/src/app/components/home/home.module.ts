import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HomeComponent } from "./home.component";
import { NavBarComponent } from "./shared-home/navbar.component";
import { MDBBootstrapModule } from "angular-bootstrap-md";
import { UsuariosListaComponent } from "./usuario/usuarios-lista/usuarios-lista.component";
import { HomeRoutingModule } from "./home.routing.module";
import { UsuarioService } from "src/app/services/home/usuario.service";
import { UsuarioDetalheComponent } from "./usuario/usuario-detalhe/usuario-detalhe.component";
import { FormsModule } from "@angular/forms";


@NgModule({
    declarations: [
        HomeComponent,
        UsuariosListaComponent,
        UsuarioDetalheComponent,
        NavBarComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        HomeRoutingModule,
        MDBBootstrapModule,
    ],
    providers: [
        UsuarioService
    ]
})
export class HomeModule { }