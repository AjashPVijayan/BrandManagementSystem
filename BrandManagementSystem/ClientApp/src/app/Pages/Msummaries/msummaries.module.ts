import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MsummariesRoutingModule } from './msummaries-routing.module';
import { CMScorecardComponent } from './cmscorecard/cmscorecard.component';


@NgModule({
  declarations: [
    CMScorecardComponent
  ],
  imports: [
    CommonModule,
    MsummariesRoutingModule
  ]
})
export class MsummariesModule { }
