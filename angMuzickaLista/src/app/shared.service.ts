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
      getPjesmeList():Observable<any[]>{
        return this.http.get<any>(this.apiUrl+'/Pjesme');
      }
     getKategorije():Observable<any[]>{
      return this.http.get<any>(this.apiUrl+'/Kategorije');
    }
     
      // updatePjesma(val:any){
      //   return this.http.put(this.APIUrl+'/Pjesme',val);
      // }
      // delete(url: string, id: number) {
      //   return this.http.delete(`${environment.apiUrl}${url}/${id}`);
      // }
      delete(val:any){
        return this.http.delete(this.apiUrl+'/Pjesme/'+val);
      }
      save(url: string, order: any) {
        return this.http.post(`${environment.apiUrl}${url}`, order);
       }
      
       update(url: string, order: any) {
         return this.http.put(`${environment.apiUrl}${url}`, order);
       }
      
}