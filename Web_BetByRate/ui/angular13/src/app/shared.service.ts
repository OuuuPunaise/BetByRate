import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  /*
  //readonly ApiUrl="https://localhost:4200/api";
  readonly ApiUrl="https://localhost:44374/api";

  constructor(private http:HttpClient) { }

  getSportList():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+'/sport');
  }

  getAllSportNames():Observable<any[]>{
    return this.http.get<any[]>(this.ApiUrl+'/Sport/GetAllSportNames')
  }*/

}
