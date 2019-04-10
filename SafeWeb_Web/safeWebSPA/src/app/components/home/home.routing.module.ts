import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { UsuariosListaComponent } from "./usuario/usuarios-lista/usuarios-lista.component";
import { UsuarioDetalheComponent } from "./usuario/usuario-detalhe/usuario-detalhe.component";

const homeRoutes: Routes = [
    { path: 'usuario/listagem', component: UsuariosListaComponent },
    { path: 'usuario/listagem/detalhe', component: UsuarioDetalheComponent },
    { path: 'usuario/listagem/detalhe/:id', component: UsuarioDetalheComponent }
]

@NgModule({
    imports: [
        RouterModule.forChild(homeRoutes)
    ],
    exports: [RouterModule]
})
export class HomeRoutingModule { }