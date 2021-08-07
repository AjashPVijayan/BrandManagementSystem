import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EscorecardComponent } from './escorecard/escorecard.component'
import { CMScorecardComponent} from './cmscorecard/cmscorecard.component'

const routes: Routes = [
  {path:'',redirectTo:'EScard'},
  {path:'EScard',component:EscorecardComponent},
{path:'CMScard',component:CMScorecardComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MsummariesRoutingModule { }
