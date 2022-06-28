import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Iprovider } from '../../interface/Iprovider';
import { API_PATH } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProviderService {
  private baseUrl: string
  constructor(private http: HttpClient) {
    this.baseUrl = API_PATH
  }

  getProvider(): Observable<Iprovider> {
    return this.http.get<Iprovider>(`${this.baseUrl}/provider/GetAll`).pipe();
  }

}
