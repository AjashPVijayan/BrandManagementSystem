import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizationComponent } from './authorization/authorization.component'
import { AlertComponent } from './alert/alert.component'

const routes: Routes = [
  {path:'',redirectTo:'Auth'},
{path:'Auth',component:AuthorizationComponent},
{path:'Alert',component:AlertComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
