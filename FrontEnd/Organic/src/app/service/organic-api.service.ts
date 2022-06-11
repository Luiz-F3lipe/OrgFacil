import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { API_PATH } from 'src/environments/environment';
import { Iprovider } from '../interface/Iprovider';

@Injectable({
  providedIn: 'root'
})
export class OrganicApiService {

  constructor(private httpClient: HttpClient) { }

  public getProvider() {
    return this.httpClient.get<Iprovider[]>(`${API_PATH}Providers`);
  }

  public getProviderById(Id: number) {
    return this.httpClient.get<Iprovider>(`${API_PATH}Providers/${Id}`);
  }
}
