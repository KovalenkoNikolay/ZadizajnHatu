import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { DesignStudioPreviewComponent } from './modules/home/components/design-studio-preview/design-studio-preview.component';
import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './modules/home/pages/app.component';
import { FooterComponent } from './core/footer/footer.component';
import { HeaderComponent } from './core/header/header.component';
import { LeftbarComponent } from './core/leftbar/leftbar.component';
import { MainComponent } from './modules/home/components/main/main.component';
import { HttpClientModule } from '@angular/common/http';
import { DesignStudioFilterComponent } from './modules/home/components/design-studio-filter/design-studio-filter.component';
import { DesignStudioDetailsComponent } from './modules/home/components/design-studio-details/design-studio-details.component';

import  { PageStateService } from './core/services/page-state.service';
import { DesignStudioComponent } from './modules/home/components/design-studio/design-studio.component';

 


@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    LeftbarComponent,
    MainComponent,
    DesignStudioPreviewComponent,
    routingComponents,
    DesignStudioFilterComponent,
    DesignStudioDetailsComponent,
    DesignStudioComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [PageStateService],
  bootstrap: [AppComponent]
})
export class AppModule { }
