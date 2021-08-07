import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'',redirectTo:'Msummaries',pathMatch:'full'},
  {path:'Msummaries',loadChildren:()=>import('../Pages/Msummaries/msummaries.module').then(m=>m.MsummariesModule)},
  {path:'DeepDive',loadChildren:()=>import('../Pages/Deepdive/deepdive.module').then(m=>m.DeepdiveModule)},
  {path:'Admin',loadChildren:()=>import('../Admin/admin.module').then(m=>m.AdminModule)}
 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PagesRoutingModule { }
