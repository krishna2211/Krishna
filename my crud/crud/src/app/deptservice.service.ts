
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
 import { Department } from './department';
import {  Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class DeptserviceService {

  private apiURL = " http://localhost:27789/api/depts";
    post:any;
    
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
   
  constructor(private httpClient: HttpClient) { }
    
  getAll(): Observable<Department[]> {
    return this.httpClient.get<Department[]>(this.apiURL + '/depts/')
    .pipe(
      catchError(this.errorHandler)
    )
  }
    
  create(post: any): Observable<Department> {
    return this.httpClient.post<Department>(this.apiURL + '/depts/', JSON.stringify(post), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }  
    
  find(id: string): Observable<Department> {
    return this.httpClient.get<Department>(this.apiURL + '/depts/' + id)
    .pipe(
      catchError(this.errorHandler)
    )
  }
    
  update(id: string, post: any): Observable<Department> {
    return this.httpClient.put<Department>(this.apiURL + '/posts/' + id, JSON.stringify(post), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }
    
  delete(id: string){
    return this.httpClient.delete<Department>(this.apiURL + '/posts/' + id, this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }
    
   
  errorHandler(error: { error: { message: string; }; status: any; message: any; }) {
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
 }
}