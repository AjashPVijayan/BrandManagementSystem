import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthorizationComponent } from './Admin/authorization/authorization.component';
import { AlertComponent } from './Admin/alert/alert.component';
import { PagesComponent } from './Layout/pages/pages.component';
import { EscorecardComponent } from './Pages/Msummaries/escorecard/escorecard.component';
import { PointintimeComponent } from './Pages/Deepdive/pointintime/pointintime.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthorizationComponent,
    AlertComponent,
    PagesComponent,
    EscorecardComponent,
    PointintimeComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
