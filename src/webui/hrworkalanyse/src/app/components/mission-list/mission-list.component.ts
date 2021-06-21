import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Mission } from 'src/app/models/mission';
import { MissionService } from 'src/app/services/mission.service';
import { AddMissionComponent } from '../add-mission/add-mission.component';

@Component({
  selector: 'app-mission-list',
  templateUrl: './mission-list.component.html',
  styleUrls: ['./mission-list.component.css']
})
export class MissionListComponent implements OnInit {
  displayedColumns: string[] = ['index','missionName','missionTime','repeatTime', "annualTime", 'operations'];
  tableFooterColumns: string[] = ['total'];
  dataSource:MatTableDataSource<Mission>;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  missionData:Mission[];
  totalMissionTime:number;
  constructor(
    public dialogRef: MatDialogRef<MissionListComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    public dialog: MatDialog,
    private missionService: MissionService,
  ) { 
    dialogRef.disableClose = true;
  }

  ngOnInit() {
    this.getMissionData(this.data);
  }

  getMissionData(titleId:number){
    this.missionService.GetMissionsByTitle(titleId).subscribe(result => {
      this.missionData = result.data;
      this.dataSource = new MatTableDataSource(this.missionData)
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
      this.totalMissionTime = this.calculateTotalMissionTime(this.missionData)
    })
  }


  onNoClick(): void {
    this.dialogRef.close();
  }

  tableSearch(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  calculateTotalMissionTime(missionData:Mission[]){
    let totalMissionTime = 0;
    for (let data of this.missionData){
      totalMissionTime += data.annualRepeatCount * data.missionTime
    }
    return totalMissionTime;
    }

    openMissionAddDialog(){
      const dialogRef = this.dialog.open(AddMissionComponent, {
        width: 'auto',
        height: 'auto',
        data: this.data
      }
      );
      dialogRef.afterClosed().subscribe(result =>{
        console.log(" out mission add comp returned result",result);
        if (result) {
          this.missionData.push(result)
          this.totalMissionTime = this.calculateTotalMissionTime(this.missionData);
          this.dataSource = new MatTableDataSource(this.missionData)        
        } 
      }) 
    }

    deleteMission(missionId:number){
      this.missionService.DeleteMission(missionId).subscribe(result => {
        this.getMissionData(this.data)
      })
    }

}
