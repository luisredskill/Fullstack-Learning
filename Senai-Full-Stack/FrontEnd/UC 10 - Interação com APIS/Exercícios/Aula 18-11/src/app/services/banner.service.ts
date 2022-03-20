import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Banner } from '../models/banner';

@Injectable({
  providedIn: 'root'
})
export class BannerService {

  url = "http://localhost:3000/banner"

  constructor(private httpClient: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders ({ 'Content-Type': 'application/json'})
  }
  getBannerinfo(): Observable<Banner[]>{
    return this.httpClient.get<Banner[]>(this.url)
  }
}
