import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PagesComponent } from './Layout/pages/pages.component';
import {HomeComponent} from './home/home.component'

const routes: Routes = [
   {path:'',component:HomeComponent},
  {path:'Module',component:PagesComponent,loadChildren: ()=> import('./Layout/pages.module').then(m=>m.PagesModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
