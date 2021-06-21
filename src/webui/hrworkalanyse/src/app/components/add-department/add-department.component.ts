import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Department } from 'src/app/models/department';
import { DepartmentService } from 'src/app/services/department.service';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent implements OnInit {

  departmentAddForm:FormGroup;
  companyId:number;
  constructor( 
    public dialogRef: MatDialogRef<AddDepartmentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    private formBuilder: FormBuilder,
    public dialog: MatDialog,
    private departmentService: DepartmentService,
    ) { 
      this.companyId = data     
    }

  ngOnInit() {
    this.createDepartmentFrom();   
  }

  createDepartmentFrom(){
    this.departmentAddForm = this.formBuilder.group({
      departmentName: ['', Validators.required]
    })
  }

  addDepartment(){
    let departmentModel:Department = Object.assign({}, this.departmentAddForm.value);
    if (this.departmentAddForm.valid) {
      departmentModel.companyId = this.companyId
      this.departmentService.AddDepartment(departmentModel).subscribe(response => {
      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
