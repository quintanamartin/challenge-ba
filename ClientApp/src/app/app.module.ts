import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

// Componentes
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { DniformComponent } from './components/dniform/dniform.component';
import { VisitformComponent } from './components/visitform/visitform.component';
import { RecordsComponent } from './components/records/records.component';

@NgModule({
  declarations: [
    AppComponent,
    DniformComponent,
    HeaderComponent,
    RecordsComponent,
    VisitformComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
