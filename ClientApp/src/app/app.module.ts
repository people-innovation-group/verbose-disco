import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { Globals } from './globals';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

import { AppInitService } from './app-init.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 
export function initializeApp1(globals: Globals, appInitService: AppInitService) {
  return (): Promise<any> => { 
    return appInitService.Init(globals);
  }
}

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    BrowserAnimationsModule,
    MatFormFieldModule, MatSelectModule, MatProgressSpinnerModule
  ],
  providers: [AppInitService,
    { provide: APP_INITIALIZER, useFactory: initializeApp1, deps: [Globals, AppInitService], multi: true },
    Globals
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
