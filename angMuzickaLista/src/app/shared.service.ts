import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { environment } from 'src/environments/environment'; 
import {Observable} from 'rxjs';
@Injectable({
    providedIn: 'root'
  })
export class SharedService {
  readonly apiUrl="https://localhost:44398/api";

    constructor(private http:HttpClient ) { }

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
      };
      getPjesmeList():Observable<any[]>
      {
        return this.http.get<any>(this.apiUrl+'/Pjesme');
      }
     getKategorije():Observable<any[]>
     {
      return this.http.get<any>(this.apiUrl+'/Kategorije');
    }
      delete(val:any){
        return this.http.delete(this.apiUrl+'/Pjesme/'+val);
      }
       update( id: any, order: any) {
        return this.http.put(this.apiUrl+'/Pjesme/'+id, order);
      }
      save(order: any) {
        return this.http.post<any>(this.apiUrl + '/Pjesme', order);
      }
}