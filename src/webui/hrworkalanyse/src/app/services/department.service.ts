import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Department } from '../models/department';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';
import { SingleResponseModel } from '../utilities/response-models/singleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetDepartments(companyId:number): Observable<ListResponseModel<Department>> {
    return this.httpClient.get<ListResponseModel<Department>>(this.baseUrl + "departments/company/"+ companyId)
  }

  GetDepartment(departmentId:number): Observable<SingleResponseModel<Department>> {
    return this.httpClient.get<SingleResponseModel<Department>>(this.baseUrl + "departments/"+ departmentId)
  }

  GetDepartmentByTitle(titleId:number): Observable<SingleResponseModel<Department>> {
    return this.httpClient.get<SingleResponseModel<Department>>(this.baseUrl + "departments/title/"+ titleId)
  }

  AddDepartment(department:Department):Observable<ResponseModel>{
    return this.httpClient.post<ResponseModel>(this.baseUrl + "departments", department);
  }

}
