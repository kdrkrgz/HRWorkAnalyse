import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { Department } from 'src/app/models/department';
import { Employee } from 'src/app/models/employee';
import { PhoneCall } from 'src/app/models/phoneCall';
import { Title } from 'src/app/models/title';
import { DepartmentService } from 'src/app/services/department.service';
import { EmployeeService } from 'src/app/services/employee.service';
import { PhonecallService } from 'src/app/services/phonecall.service';
import { TitleService } from 'src/app/services/title.service';
import { AddEmployeeComponent } from '../add-employee/add-employee.component';
import { AddPhonecallComponent } from '../add-phonecall/add-phonecall.component';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  displayedColumns: string[] = ['index','firstName','lastName', 'addButtons', 'operations'];
  dataSource:MatTableDataSource<Employee>;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  employeeData:Employee[]
  titleData: Title;
  departmentData: Department;
  phoneCallsData:PhoneCall[];
  constructor(private employeeService:EmployeeService,
    private activatedRoute: ActivatedRoute,
    private titleService: TitleService,
    private phoneCallService:PhonecallService,
    public dialog:MatDialog
     ) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.getEmployeesByTitle(params["titleId"])
      this.getTitle(params["titleId"])
    });
  }

  getEmployeesByTitle(titleId:number){
    this.employeeService.GetEmployeesByTitle(titleId).subscribe(response => {
      this.employeeData = response.data;
      this.dataSource = new MatTableDataSource(this.employeeData)
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;      
    })
  }

  getTitle(titleId:number){
    this.titleService.GetTitle(titleId).subscribe(response => {
      this.titleData = response.data;
      this.getPhoneCallsByTitle(response.data.id)
    })
  }

  getPhoneCallsByTitle(titleId:number){
    this.phoneCallService.GetPhoneCallsByTitle(titleId).subscribe(response => {
      this.phoneCallsData = response.data;     
    })
  }

  searchInPhoneCalls(employeeId:number){
    return this.phoneCallsData.filter(x => x.employeeId === employeeId).length
  }

  
  tableSearch(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  openEmployeeAddDialog(){
    const dialogRef = this.dialog.open(AddEmployeeComponent, {
      width: '750px',
      maxHeight: 750,
      data: this.titleData.id
    }
    );

    
    dialogRef.afterClosed().subscribe(result => {
      this.getEmployeesByTitle(this.titleData.id)
      console.log("updated employee data", this.employeeData);
    })
  }

  passEmployeeIdPhonaCallAddDialog(employeeId:number){
    this.openPhoneCallAddDialog(employeeId)
  }
  openPhoneCallAddDialog(employeeId:number){
    const dialogRef = this.dialog.open(AddPhonecallComponent, {
      width: '750px',
      maxHeight: 750,
      data: employeeId
    }
    );
    dialogRef.afterClosed().subscribe(result => {
      this.getPhoneCallsByTitle(this.titleData.id)
      console.log("updated employee data", this.phoneCallsData);
    })
}

deleteEmployee(employeeId:number){
  this.employeeService.DeleteEmployee(employeeId).subscribe(result => {
    this.getEmployeesByTitle(this.titleData.id)
  })
}

updateEmployee(employee:any){

}

}
