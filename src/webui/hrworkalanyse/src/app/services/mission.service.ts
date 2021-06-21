import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Mission } from '../models/mission';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class MissionService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetMissionsByTitle(titleId:number): Observable<ListResponseModel<Mission>> {
    return this.httpClient.get<ListResponseModel<Mission>>(this.baseUrl + "missions/title/"+ titleId)
  }

  AddMission(missionData:Mission): Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(this.baseUrl + "missions", missionData)
  }

  DeleteMission(missionId:number): Observable<ResponseModel> {
    return this.httpClient.delete<ResponseModel>(this.baseUrl + "missions/"+ missionId)
  }
}
