import { Routes } from '@angular/router';
import { LoginPagComponent } from './pages/login-pag/login-pag.component';
import { HomePagComponent } from './pages/home-pag/home-pag.component';

export const routes: Routes = [
    { path: 'login', component: LoginPagComponent },
    { path: '', children: 
        [
            { path: '', component: HomePagComponent },
        ],
     },
];
