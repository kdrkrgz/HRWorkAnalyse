import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddPermit } from 'src/app/models/addPermit';
import { Permit } from 'src/app/models/permit';
import { PermitService } from 'src/app/services/permit.service';

@Component({
  selector: 'app-add-permit',
  templateUrl: './add-permit.component.html',
  styleUrls: ['./add-permit.component.css']
})
export class AddPermitComponent implements OnInit {

  permitAddForm:FormGroup;

  constructor( 
    public dialogRef: MatDialogRef<AddPermitComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    private formBuilder: FormBuilder,
    public dialog: MatDialog,
    private permitService: PermitService,
    ) {       
    }

  ngOnInit() {
    this.createPermitFrom();   
  }
  createPermitFrom(){
    this.permitAddForm = this.formBuilder.group({
      name: ['', Validators.required],
      permitTime: ['', Validators.required]
    })
  }

  addPermit(){
    let permitModel:AddPermit = Object.assign({}, this.permitAddForm.value);
    if (this.permitAddForm.valid) {
      permitModel.titleId = this.data
      this.permitService.AddPermit(permitModel).subscribe(response => {
      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
