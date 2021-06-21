import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { Permit } from 'src/app/models/permit';
import { Title } from 'src/app/models/title';
import { PermitService } from 'src/app/services/permit.service';
import { TitleService } from 'src/app/services/title.service';
import { AddPermitComponent } from '../add-permit/add-permit.component';

@Component({
  selector: 'app-permit',
  templateUrl: './permit.component.html',
  styleUrls: ['./permit.component.css']
})
export class PermitComponent implements OnInit {

  permitData:Permit[]
  annualPermitTime:number
  titleData:Title;

  constructor(private permitService:PermitService,
    private activatedRoute: ActivatedRoute,
    private titleService:TitleService,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.getPermitssByTitle(params["titleId"]);
      this.getTitle(params["titleId"]);
    });
  }

  getPermitssByTitle(titleId:number){
    this.permitService.GetPermitsByTitle(titleId).subscribe(response => {
      this.permitData = response.data;
      this.annualPermitTime = this.annualPermitSum(this.permitData);
    })
  }

  getTitle(titleId:number){
    this.titleService.GetTitle(titleId).subscribe(response => {
      this.titleData = response.data;
    })
  }


  annualPermitSum(permitData: Permit[]) {
    let annulPermitTime = 0
    for (let data of this.permitData) {
      annulPermitTime += data.permitTime
    }
    
    return annulPermitTime;
  }

  openPermitAddDialog(){
    const dialogRef = this.dialog.open(AddPermitComponent, {
      width: '750px',
      maxHeight: 750,
      data: this.titleData.id
    }
    ); 
    dialogRef.afterClosed().subscribe(result =>{
      let addedPermit:Permit=Object.assign(result);
      addedPermit.permitTime = parseInt(result["permitTime"]);
      this.permitData.push(addedPermit)
      this.annualPermitTime = this.annualPermitSum(this.permitData)
    })
  }
}
