import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Title } from 'src/app/models/title';
import { TitleService } from 'src/app/services/title.service';

@Component({
  selector: 'app-add-title',
  templateUrl: './add-title.component.html',
  styleUrls: ['./add-title.component.css']
})
export class AddTitleComponent implements OnInit {

  titleAddForm: FormGroup
  constructor(
    public dialogRef: MatDialogRef<AddTitleComponent>,
    @Inject(MAT_DIALOG_DATA) public data: number,
    private formBuilder: FormBuilder,
    public dialog: MatDialog,
    private titleService: TitleService,
  ) { }

  ngOnInit() {
    this.createTitleFrom();
  }

  createTitleFrom(){
    this.titleAddForm = this.formBuilder.group({
      titleName: ['', Validators.required]
    })
  }

  addTitle(){
    let titleModel:Title = Object.assign({}, this.titleAddForm.value);
    if (this.titleAddForm.valid) {
      titleModel.departmentId = this.data
      this.titleService.AddTitle(titleModel).subscribe(response => {
      })
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
