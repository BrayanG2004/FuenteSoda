import { Routes } from '@angular/router';
import { LoginPagComponent } from './pages/login-pag/login-pag.component';
import { HomePagComponent } from './pages/home-pag/home-pag.component';
import { ProductsPageComponent } from './pages/products/products-page/products-page.component';
import { ProductsAddPageComponent } from './pages/products/products-add-page/products-add-page.component';
import { ProductsEditPageComponent } from './pages/products/products-edit-page/products-edit-page.component';

export const routes: Routes = [
    { path: 'login', component: LoginPagComponent },
    { path: '', 
        children: 
        [
            { path: '', 
                component: HomePagComponent 
                },
            { path: 'home', 
            component: HomePagComponent 
            },
            {
            path: 'products',
                children: [
                    {
                        path:'',
                        component : ProductsPageComponent,

                    },
                    {
                        path: 'add',
                        component: ProductsAddPageComponent
                    },
                    {
                        path: 'edit',
                        component: ProductsEditPageComponent
                    },
                ]           
            }
        ],
     },
];
