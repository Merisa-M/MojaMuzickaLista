import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
@Injectable({
    providedIn: 'root'
  })
export class SharedService {

    readonly APIUrl="https://localhost:44398/api";
    constructor(private http:HttpClient ) { }

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
      };
      getPjesmeList():Observable<any[]>{
        return this.http.get<any>(this.APIUrl+'/Pjesme');
      }
      addPjesma(val:any){
        return this.http.post(this.APIUrl+'/Pjesme',val);
      }
      updatePjesma(val:any){
        return this.http.put(this.APIUrl+'/Pjesme',val);
      }
      deletePjesma(val:any){
        return this.http.delete(this.APIUrl+'/pjesme',val);
      }
      getKategorije(val:any){
        return this.http.delete(this.APIUrl+'/kategorije',val);
      }
}