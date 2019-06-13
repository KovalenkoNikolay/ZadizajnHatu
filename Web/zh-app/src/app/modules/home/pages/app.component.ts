import { Component } from '@angular/core';
import { PageStateService } from '../../../core/services/page-state.service';

@Component({
  providers: [PageStateService],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'zh-app';
}
