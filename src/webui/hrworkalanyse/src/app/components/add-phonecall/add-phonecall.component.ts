import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddPhoneCall } from 'src/app/models/addPhoneCall';
import { PhonecallService } from 'src/app/services/phonecall.service';

@Component({
  selector: 'app-add-phonecall',
  templateUrl: './add-phonecall.component.html',
  styleUrls: ['./add-phonecall.component.css']
})
export class AddPhonecallComponent implements OnInit {
  phoneCallAddForm:FormGroup;

  constructor(
    public dialogRef: MatDialogRef<AddPhonecallComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    private formBuilder: FormBuilder,
    public dialog: MatDialog,
    private phoneCallService: PhonecallService
  ) {        
  }

  ngOnInit() {
    this.createPhoneCallFrom();
  }

  createPhoneCallFrom(){
    this.phoneCallAddForm = this.formBuilder.group({
      inCompany: ['', Validators.required],
      outCompany: ['', Validators.required]
    })
  }

  addPhoneCall(){
    let phoneCalll:AddPhoneCall = Object.assign({}, this.phoneCallAddForm.value)
    if (this.phoneCallAddForm.valid) {
      phoneCalll.employeeId = this.data;
      this.phoneCallService.AddPhoneCall(phoneCalll).subscribe(response => {

      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
