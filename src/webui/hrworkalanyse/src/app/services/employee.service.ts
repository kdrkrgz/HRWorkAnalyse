import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AddEmployee } from '../models/addEmployee';
import { Employee } from '../models/employee';
import { ListResponseModel } from '../utilities/response-models/listResponseModel';
import { ResponseModel } from '../utilities/response-models/responseModel';
import { SingleResponseModel } from '../utilities/response-models/singleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private httpClient:HttpClient) { }
  baseUrl:string = environment.backend.baseURL;
  
  
  GetEmployeesByTitle(titleId:number): Observable<ListResponseModel<Employee>> {
    return this.httpClient.get<ListResponseModel<Employee>>(this.baseUrl + "employees/title/"+ titleId)
  }

  GetEmployee(employeeId:number): Observable<SingleResponseModel<Employee>> {
    return this.httpClient.get<SingleResponseModel<Employee>>(this.baseUrl + "employees/"+ employeeId)
  }

  AddEmployee(addEmployeeData:AddEmployee):Observable<ResponseModel> {
    return this.httpClient.post<ResponseModel>(this.baseUrl + "employees", addEmployeeData)
  }

  DeleteEmployee(employeeId:number): Observable<ResponseModel> {
    return this.httpClient.delete<ResponseModel>(this.baseUrl + "employees/"+ employeeId)
  }
}
