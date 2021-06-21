import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Company } from 'src/app/models/company';
import { Department } from 'src/app/models/department';
import { CompanyService } from 'src/app/services/company.service';
import { DepartmentService } from 'src/app/services/department.service';
import { AddDepartmentComponent } from '../add-department/add-department.component';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {
  DepartmentData:Department[];
  companyId:number;
  companyData:Company;

  constructor(private departmentService:DepartmentService,    
    private activatedRoute:ActivatedRoute,
    private companyService: CompanyService,
    public dialog: MatDialog
    ) {
     }
  
  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.getDepartmentsByCompany(params["companyId"])
      this.getCompany(params["companyId"])
    })
  }

  getDepartmentsByCompany(companyId:number){
    this.departmentService.GetDepartments(companyId).subscribe(response => {
      this.DepartmentData = response.data as Department[];      
    });
  }

  getCompany(companyId:number){
    this.companyService.GetCompany(companyId).subscribe(response => {
      this.companyData = response.data;
      this.companyId = response.data.id;      
    });
  }

  openDepartmentAddDialog() {
    const dialogRef = this.dialog.open(AddDepartmentComponent, {
      width: '750px',
      maxHeight: 750,
      data: this.companyId
    }
    );

    dialogRef.afterClosed().subscribe(result =>{
      this.getDepartmentsByCompany(this.companyId)
      console.log("updated departments", this.DepartmentData);
       
    }) 
  }
}
