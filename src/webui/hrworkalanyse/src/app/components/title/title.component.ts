import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { Department } from 'src/app/models/department';
import { Title } from 'src/app/models/title';
import { DepartmentService } from 'src/app/services/department.service';
import { TitleService } from 'src/app/services/title.service';
import { AddEmployeeComponent } from '../add-employee/add-employee.component';
import { AddPermitComponent } from '../add-permit/add-permit.component';
import { AddTitleComponent } from '../add-title/add-title.component';
import { MissionListComponent } from '../mission-list/mission-list.component';
@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.css'],

})
export class TitleComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['index','title','lists', 'operations'];
  dataSource:MatTableDataSource<Title>;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  titleData:Title[];
  departmentData: Department;

  constructor(private titleService:TitleService,
    private activatedRoute: ActivatedRoute,
    private departmantService: DepartmentService,
    public dialog: MatDialog
    ) { 
      this.activatedRoute.params.subscribe(params => {
        this.getTitlesByDepartment(params["departmentId"])
        this.getDepartment(params["departmentId"])
      });
    }
  ngAfterViewInit(): void {
  }

  ngOnInit() {
  }


  getTitlesByDepartment(departmentId:number){
    this.titleService.GetTitlesByDepartment(departmentId).subscribe(response => {
      this.titleData = response.data;
      this.dataSource = new MatTableDataSource(this.titleData)
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  getDepartment(departmentId:number){
    this.departmantService.GetDepartment(departmentId).subscribe(response => {
      this.departmentData = response.data;
    });
  }

  tableSearch(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
 

  openTitleAddDialog(){
    const dialogRef = this.dialog.open(AddTitleComponent, {
      width: '750px',
      maxHeight: 750,
      data: this.departmentData.id
    }
    );
    dialogRef.afterClosed().subscribe(result =>{
      if (result) {
        this.titleData.push(result)
        this.dataSource = new MatTableDataSource(this.titleData)        
      } 
    }) 
  }


  openMissionListDialog(titleId:number){
    const dialogRef = this.dialog.open(MissionListComponent, {
      width: "100%",
      minHeight: 'calc(100vh - 90px)',
      height: 'auto',
      data: titleId
    }
    );
  }

  removeTitle(titleId:number){
    this.titleService.DeleteTitle(titleId).subscribe(response => {
      console.log("delete resp", response);
      this.getTitlesByDepartment(this.departmentData.id)
    })
  }
  

}
