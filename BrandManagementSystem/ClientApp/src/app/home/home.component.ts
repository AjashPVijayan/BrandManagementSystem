import { Component,OnInit } from '@angular/core';
import { BrandsService } from '../Services/brands.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private Serviceobj :BrandsService){  }
  public DataFromservice;
  ngOnInit()
  {
    debugger;
    this.Serviceobj.GetData().subscribe(dataS=>{
      this.DataFromservice =dataS;
    });
  }
  //getDataFromservice()
  //{
  //  this.Serviceobj.GetData().subscribe();
 // }
}
