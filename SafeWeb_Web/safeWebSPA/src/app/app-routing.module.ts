import { NgModule } from "@angular/core";
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from "./components/login/login.component";
import { HomeComponent } from "./components/home/home.component";
import { UsuariosListaComponent } from "./components/home/usuario/usuarios-lista/usuarios-lista.component";
import { UsuarioDetalheComponent } from "./components/home/usuario/usuario-detalhe/usuario-detalhe.component";

const ROUTES: Routes = [
    { path: '', component: LoginComponent, pathMatch: 'full', data: { title: 'Gestão de Compras' } },
    { path: 'home', component: HomeComponent, data: { title: 'Home - Gestão de Compras' } },
    { path: 'usuario', redirectTo: 'usuario/listagem', pathMatch: 'full' },
    {
        path: 'usuario/listagem', component: UsuariosListaComponent,
    }
]


@NgModule({
    imports: [
        RouterModule.forRoot(ROUTES)
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule { }