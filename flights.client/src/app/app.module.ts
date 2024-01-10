import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { SearchFlightComponent } from './search-flight/search-flight.component';
import { BookFlightComponent } from './book-flight/book-flight.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    SearchFlightComponent,
    BookFlightComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([

      { path: '', component: SearchFlightComponent, pathMatch: 'full' },
      { path: 'search-flights', component: SearchFlightComponent},
      { path: 'book-flight/:flightId', component: BookFlightComponent},

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }



