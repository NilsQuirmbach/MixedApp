import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { appRoutingProviders, routing } from './app.routes';

import { CompanyEditComponent } from './company-edit/company-edit.component';
import { CompanyListComponent } from './company-list/company-list.component';
import { CompanyService, UserService } from './shared';

@NgModule({
  declarations: [
      AppComponent,
      CompanyEditComponent,
      CompanyListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    routing
  ],
  providers: [
      appRoutingProviders,
      CompanyService,
      UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
