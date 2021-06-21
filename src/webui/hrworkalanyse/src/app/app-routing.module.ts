import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompanyComponent } from './components/company/company.component';
import { DepartmentComponent } from './components/department/department.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { MissionComponent } from './components/mission/mission.component';
import { PermitComponent } from './components/permit/permit.component';
import { PhonecallComponent } from './components/phonecall/phonecall.component';
import { TitleComponent } from './components/title/title.component';

const routes: Routes = [
  {path: "companies", component: CompanyComponent},
  {path: "departments/:companyId", component: DepartmentComponent},
  {path: "titles/:departmentId", component: TitleComponent},
  {path: "employees/:titleId", component: EmployeeComponent},
  {path: "permits/:titleId", component: PermitComponent},
  {path: "missions/:titleId", component: MissionComponent},
  {path: "phonecalls/:employeeId", component: PhonecallComponent},
  
  {path: '',  redirectTo: '/',  pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { 

}
