import { Component, OnInit } from '@angular/core';
import { DesignStudioSharedDataService } from 'src/app/core/services/design-studio-shared-data.service';
import { DesignStudioSearchFilter } from 'src/app/shared/models/design-studio-search-filter';

@Component({
  selector: '[id=design-studio-filter]',
  templateUrl: './design-studio-filter.component.html',
  styleUrls: ['./design-studio-filter.component.scss']
})
export class DesignStudioFilterComponent implements OnInit {

  public slider : HTMLElement;
  public between : HTMLElement;
  public button1 : HTMLElement;
  public button2 : HTMLElement;
  public priceFrom : HTMLElement;
  public priceTo : HTMLElement;

  public defaultMin : number = 10;
  public defaultMax : number = 100;
  
  constructor(private designStudioSharedDataService : DesignStudioSharedDataService) { }

  ngOnInit() {
    this.initSlider('id66', 'id66b', 'id661', 'id662', 'priceFrom', 'priceTo')
  }

  searchDesignStudios(fromAmount: number, toAmount : number, name : string){
    let searchFilter = new DesignStudioSearchFilter();
    searchFilter.fromAmount = fromAmount;
    searchFilter.toAmount = toAmount;
    searchFilter.name = name;
    this.designStudioSharedDataService.addDesignStudioSearchFilter(searchFilter);
  }

  // FILTER
  initSlider(idX : string, btwX : string, btn1X : string, btn2X : string, priceFrom : string, priceTo){
    this.slider = document.getElementById(idX);
    this.between = document.getElementById(btwX); 
    this.button1 = document.getElementById(btn1X);
    this.button2 = document.getElementById(btn2X);
    this.priceFrom = document.getElementById(priceFrom); 
    this.priceTo = document.getElementById(priceTo);

    (this.priceFrom as HTMLInputElement).value = this.defaultMin.toString();
    (this.priceTo as HTMLInputElement).value = this.defaultMax.toString();
  }

priceFromOnChange(evt) {
  if (parseInt((this.priceFrom as HTMLInputElement).value) < this.defaultMin)
      (this.priceFrom as HTMLInputElement).value = this.defaultMin.toString();
    	if (parseInt((this.priceFrom as HTMLInputElement).value) > this.defaultMax)
      (this.priceFrom as HTMLInputElement).value = this.defaultMax.toString();
    	if (parseInt((this.priceFrom as HTMLInputElement).value) > parseInt((this.priceTo as HTMLInputElement).value))
      {
      	var temp = (this.priceFrom as HTMLInputElement).value;
    		(this.priceFrom as HTMLInputElement).value = (this.priceTo as HTMLInputElement).value;
    		(this.priceTo as HTMLInputElement).value = temp;
      }
      
      
        var sliderCoords = this.getCoords(this.slider);
        var per1 = (parseInt((this.priceFrom as HTMLInputElement).value)-this.defaultMin)*100/(this.defaultMax-this.defaultMin);
        var per2 = (parseInt((this.priceTo as HTMLInputElement).value)-this.defaultMin)*100/(this.defaultMax-this.defaultMin);
        var left1 = per1*(this.slider.offsetWidth-this.button1.offsetWidth)/100;
        var left2 = per2*(this.slider.offsetWidth-this.button1.offsetWidth)/100;
        
            this.button1.style.marginLeft = left1 + 'px'; 
            this.button2.style.marginLeft = left2 + 'px';
            
            if (left1 > left2)
              {
                this.between.style.width = (left1-left2) + 'px';
                this.between.style.marginLeft = left2 + 'px';
              }
            else
              {
                this.between.style.width = (left2-left1) + 'px';
                this.between.style.marginLeft = left1 + 'px';  
              }
}

priceToOnChange(evt){
  if (parseInt((this.priceTo as HTMLInputElement).value) < this.defaultMin)
      (this.priceTo as HTMLInputElement).value = this.defaultMin.toString();
    	if (parseInt((this.priceTo as HTMLInputElement).value) > this.defaultMax)
      (this.priceTo as HTMLInputElement).value = this.defaultMax.toString();
    	if (parseInt((this.priceFrom as HTMLInputElement).value) > parseInt((this.priceTo as HTMLInputElement).value))
      {
      	var temp = (this.priceFrom as HTMLInputElement).value;
    		(this.priceFrom as HTMLInputElement).value = (this.priceTo as HTMLInputElement).value;
    		(this.priceTo as HTMLInputElement).value = temp;
      }
      
      
        var sliderCoords = this.getCoords(this.slider);
        var per1 = (parseInt((this.priceFrom as HTMLInputElement).value)-this.defaultMin)*100/(this.defaultMax-this.defaultMin);
        var per2 = (parseInt((this.priceTo as HTMLInputElement).value)-this.defaultMin)*100/(this.defaultMax-this.defaultMin);
        var left1 = per1*(this.slider.offsetWidth-this.button1.offsetWidth)/100;
        var left2 = per2*(this.slider.offsetWidth-this.button1.offsetWidth)/100;
        
            this.button1.style.marginLeft = left1 + 'px'; 
            this.button2.style.marginLeft = left2 + 'px';
            
            if (left1 > left2)
              {
                this.between.style.width = (left1-left2) + 'px';
                this.between.style.marginLeft = left2 + 'px';
              }
            else
              {
                this.between.style.width = (left2-left1) + 'px';
                this.between.style.marginLeft = left1 + 'px';  
              }
}

public buttonLeftOnMouseDown(evt) {
    var sliderCoords = this.getCoords(this.slider);
    var betweenCoords = this.getCoords(this.between); 
    var buttonCoords1 = this.getCoords(this.button1);
    var buttonCoords2 = this.getCoords(this.button2);
    var shiftX2 = evt.pageX - buttonCoords2.left; 
    var shiftX1 = evt.pageX - buttonCoords1.left;
  
    document.onmousemove = (evt) => {
      var left1 = evt.pageX - shiftX1 - sliderCoords.left;
      var right1 = this.slider.offsetWidth - this.button1.offsetWidth;
      if (left1 < 0) left1 = 0;
      if (left1 > right1) left1 = right1;
      this.button1.style.marginLeft = left1 + 'px';                      
    
      shiftX2 = evt.pageX - buttonCoords2.left; 
      var left2 = evt.pageX - shiftX2 - sliderCoords.left;
      var right2 = this.slider.offsetWidth - this.button2.offsetWidth;            
       
      var per_min = 0;
      var per_max = 0;

      if (left1 > left2)
        {
          this.between.style.width = (left1-left2) + 'px';
          this.between.style.marginLeft = left2 + 'px';

          per_min = left2*100/(this.slider.offsetWidth-this.button1.offsetWidth);
          per_max = left1*100/(this.slider.offsetWidth-this.button1.offsetWidth);
        }
      else
        {
          this.between.style.width = (left2-left1) + 'px';
          this.between.style.marginLeft = left1 + 'px';

          per_min = left1*100/(this.slider.offsetWidth-this.button1.offsetWidth);
          per_max = left2*100/(this.slider.offsetWidth-this.button1.offsetWidth);
        }

        (this.priceFrom as HTMLInputElement).value = (this.defaultMin+Math.round((this.defaultMax-this.defaultMin)*per_min/100)).toString();
        (this.priceTo as HTMLInputElement).value = (this.defaultMin+Math.round((this.defaultMax-this.defaultMin)*per_max/100)).toString();
  };

    document.onmouseup = () => {
        document.onmousemove = document.onmouseup = null;
    };
    return false;
};

public buttonRightOnMouseDown(evt) {
  var sliderCoords = this.getCoords(this.slider);
  var betweenCoords = this.getCoords(this.between); 
  var buttonCoords1 = this.getCoords(this.button1);
  var buttonCoords2 = this.getCoords(this.button2);
  var shiftX2 = evt.pageX - buttonCoords2.left; 
  var shiftX1 = evt.pageX - buttonCoords1.left;
  
  var per_min = 0;
  var per_max = 0;

  document.onmousemove = (evt) => {
    var left2 = evt.pageX - shiftX2 - sliderCoords.left;
        var right2 = this.slider.offsetWidth - this.button2.offsetWidth;
        if (left2 < 0) left2 = 0;
        if (left2 > right2) left2 = right2;
        this.button2.style.marginLeft = left2 + 'px';                      
      
        shiftX1 = evt.pageX - buttonCoords1.left; 
        var left1 = evt.pageX - shiftX1 - sliderCoords.left;
        var right1 = this.slider.offsetWidth - this.button1.offsetWidth;            
          
        if (left1 > left2)
          {
            this.between.style.width = (left1-left2) + 'px';
            this.between.style.marginLeft = left2 + 'px';

            per_min = left2*100/(this.slider.offsetWidth-this.button1.offsetWidth);
            per_max = left1*100/(this.slider.offsetWidth-this.button1.offsetWidth);
          }
        else
          {
            this.between.style.width = (left2-left1) + 'px';
            this.between.style.marginLeft = left1 + 'px';

            per_min = left1*100/(this.slider.offsetWidth-this.button1.offsetWidth);
            per_max = left2*100/(this.slider.offsetWidth-this.button1.offsetWidth);
          }

          (this.priceFrom as HTMLInputElement).value = (this.defaultMin+Math.round((this.defaultMax-this.defaultMin)*per_min/100)).toString();
          (this.priceTo as HTMLInputElement).value = (this.defaultMin+Math.round((this.defaultMax-this.defaultMin)*per_max/100)).toString();
    };
    document.onmouseup = function() {
        document.onmousemove = document.onmouseup = null;
    };
    return false;
};

  getCoords(elem) {
    var box = elem.getBoundingClientRect();
    return {
        top: box.top + pageYOffset,
        left: box.left + pageXOffset
    };
  }
}
