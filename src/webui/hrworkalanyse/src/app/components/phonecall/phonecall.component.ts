import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Employee } from 'src/app/models/employee';
import { PhoneCall } from 'src/app/models/phoneCall';
import { EmployeeService } from 'src/app/services/employee.service';
import { PhonecallService } from 'src/app/services/phonecall.service';
import { AddPhonecallComponent } from '../add-phonecall/add-phonecall.component';

@Component({
  selector: 'app-phonecall',
  templateUrl: './phonecall.component.html',
  styleUrls: ['./phonecall.component.css']
})
export class PhonecallComponent implements OnInit {

  phoneCallData:PhoneCall[];
  employeeData:Employee;
  constructor(private phoneCallService:PhonecallService,
    private activatedRoute: ActivatedRoute,
    private employeeService:EmployeeService,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.getTitlesByDepartment(params["employeeId"])
      this.getEmployee(params["employeeId"])
    })
  }

  getTitlesByDepartment(departmentId:number){
    this.phoneCallService.GetPhoneCallsByEmployee(departmentId).subscribe(response => {
      this.phoneCallData = response.data;
    });
  }

  getEmployee(employeeId:number){
    this.employeeService.GetEmployee(employeeId).subscribe(response => {
      this.employeeData = response.data;
    });
  }

  openPhoneCallAddDialog(){
    const dialogRef = this.dialog.open(AddPhonecallComponent, {
      width: '750px',
      maxHeight: 750,
      data: this.employeeData.id
    }
    );
  }

}
