import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Mission } from 'src/app/models/mission';
import { MissionService } from 'src/app/services/mission.service';
import { PermitService } from 'src/app/services/permit.service';

@Component({
  selector: 'app-add-mission',
  templateUrl: './add-mission.component.html',
  styleUrls: ['./add-mission.component.css']
})
export class AddMissionComponent implements OnInit {

  missionAddForm:FormGroup;
  constructor(
    public dialogRef: MatDialogRef<AddMissionComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    public dialog: MatDialog,
    private missionService: MissionService,
    private formBuilder: FormBuilder
  ) { 
    console.log("2 layered data",data); 
  }

  ngOnInit() {
    this.createMissionAddForm();
  }

  createMissionAddForm(){
    this.missionAddForm = this.formBuilder.group({
      missionName:["", Validators.required],
      annualRepeatCount:["", Validators.required],
      missionTime:["", Validators.required]
    })
  }

  addMission(){
    let missionModel:Mission = Object.assign({}, this.missionAddForm.value)
    if (this.missionAddForm.valid) {
      missionModel.titleId = this.data
      console.log("mission model", missionModel);
      
      this.missionService.AddMission(missionModel).subscribe(result => {

      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
