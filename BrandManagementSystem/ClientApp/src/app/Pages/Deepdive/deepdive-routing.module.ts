import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PointintimeComponent } from './pointintime/pointintime.component';


const routes: Routes = [
  {path:'Point',component: PointintimeComponent}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DeepdiveRoutingModule { }
