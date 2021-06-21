import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AddPermit } from '../models/addPermit';
import { Permit } from '../models/permit';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class PermitService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetPermitsByTitle(titleId:number): Observable<ListResponseModel<Permit>> {
    return this.httpClient.get<ListResponseModel<Permit>>(this.baseUrl + "permits/title/"+ titleId)
  }

  AddPermit(permitData:AddPermit): Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(this.baseUrl + "permits",permitData)
  }
}