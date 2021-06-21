import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AddPhoneCall } from '../models/addPhoneCall';
import { PhoneCall } from '../models/phoneCall';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';

@Injectable({
  providedIn: 'root'
})
export class PhonecallService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetPhoneCallsByEmployee(employeeId:number): Observable<ListResponseModel<PhoneCall>> {
    return this.httpClient.get<ListResponseModel<PhoneCall>>(this.baseUrl + "phonecalls/"+ employeeId)
  }

  GetPhoneCallsByTitle(titleId:number): Observable<ListResponseModel<PhoneCall>> {
    return this.httpClient.get<ListResponseModel<PhoneCall>>(this.baseUrl + "phonecalls/title/"+ titleId)
  }

  AddPhoneCall(phoneCallData:AddPhoneCall): Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(this.baseUrl + "phonecalls", phoneCallData)
  }
}
