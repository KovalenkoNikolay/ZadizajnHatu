import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DesignStudioComponent } from './modules/home/components/design-studio/design-studio.component';
import { MainComponent } from './modules/home/components/main/main.component';

const routes: Routes = [
  {path: "designstudios/:id", component: DesignStudioComponent },
  {path: "designstudios", component: MainComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [DesignStudioComponent, MainComponent]
