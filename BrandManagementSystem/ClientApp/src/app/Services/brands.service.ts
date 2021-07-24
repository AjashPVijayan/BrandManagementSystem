import { Injectable } from '@angular/core';
import {HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class BrandsService {

  constructor(private httpclicnt : HttpClient) { }

  GetData()
  {
    return this.httpclicnt.get<any>("http://localhost:62435/api/home");
  }

   

}
