import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddEmployee } from 'src/app/models/addEmployee';
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  employeeAddForm:FormGroup;

  constructor(
    public dialogRef: MatDialogRef<AddEmployeeComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    private formBuilder: FormBuilder,
    public dialog: MatDialog,
    private employeeService: EmployeeService
  ) {        
  }

  ngOnInit() {
    this.createEmployeeFrom();
  }

  createEmployeeFrom(){
    this.employeeAddForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required]
    })
  }

  addEmployee(){
    let employee:AddEmployee = Object.assign({}, this.employeeAddForm.value)
    if (this.employeeAddForm.valid) {
      employee.titleId = this.data;
      this.employeeService.AddEmployee(employee).subscribe(response => {

      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
