import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Department } from '../models/department';
import { Title } from '../models/title';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';
import { SingleResponseModel } from '../utilities/response-models/singleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class TitleService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetTitlesByDepartment(departmentId:number): Observable<ListResponseModel<Title>> {
    return this.httpClient.get<ListResponseModel<Title>>(this.baseUrl + "titles/department/"+ departmentId)
  }

  GetTitle(titleId:number): Observable<SingleResponseModel<Title>> {
    return this.httpClient.get<SingleResponseModel<Title>>(this.baseUrl + "titles/"+ titleId)
  }

  AddTitle(titleData:Title): Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(this.baseUrl + "titles", titleData)
  }

  DeleteTitle(titleId:number): Observable<ResponseModel> {
    return this.httpClient.delete<ResponseModel>(this.baseUrl + "titles/"+ titleId)
  }
  
}
