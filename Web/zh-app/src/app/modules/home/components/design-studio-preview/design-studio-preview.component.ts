import { Component, OnInit, Input } from '@angular/core';
import { DesignStudio } from 'src/app/shared/models/designstudio';
import { Router } from '@angular/router';

@Component({
  selector: '[id=design-studio-preview]',
  templateUrl: './design-studio-preview.component.html',
  styleUrls: ['./design-studio-preview.component.scss']
})
export class DesignStudioPreviewComponent implements OnInit {

  @Input() designStudio : DesignStudio;

  constructor(private router : Router) { 
    
  }

  ngOnInit() {
  }
 
  onSelect(id){
    this.router.navigate(['/designstudios', id]);
  }
}
