import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Company } from '../models/company';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { SingleResponseModel } from '../utilities/response-models/singleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

constructor(private httpClient:HttpClient) { }
baseUrl:string = environment.backend.baseURL;

GetCompany(id:number): Observable<SingleResponseModel<Company>> {
  return this.httpClient.get<SingleResponseModel<Company>>(this.baseUrl + "companies/" + id)
}

GetCompanies(): Observable<ListResponseModel<Company>> {
  return this.httpClient.get<ListResponseModel<Company>>(this.baseUrl + "companies")
}
}

