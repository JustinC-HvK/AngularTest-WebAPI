import { Injectable, Input } from '@angular/core';

import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  //variable to find information through webapi
  readonly APIUrl="http://localhost:54771/api";

  constructor(private http:HttpClient) { }

  //retrive list from api
  getProList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/product')
    
    
  }

}
