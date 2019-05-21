import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { DesignStudioPreviewComponent } from './components/design-studio-preview/design-studio-preview.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './pages/app.component';
import { FooterComponent } from '../../core/footer/footer.component';
import { HeaderComponent } from '../../core/header/header.component';
import { LeftbarComponent } from '../../core/leftbar/leftbar.component';
import { MainComponent } from './components/main/main.component';
import { HttpClientModule } from '@angular/common/http';




@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    LeftbarComponent,
    MainComponent,
    DesignStudioPreviewComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
