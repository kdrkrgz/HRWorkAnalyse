import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatTableModule } from '@angular/material/table';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { CompanyComponent } from './components/company/company.component';
import { DepartmentComponent } from './components/department/department.component';
import { TitleComponent } from './components/title/title.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { PhonecallComponent } from './components/phonecall/phonecall.component';
import { PermitComponent } from './components/permit/permit.component';
import { MissionComponent } from './components/mission/mission.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule, MAT_FORM_FIELD_DEFAULT_OPTIONS} from '@angular/material/form-field';
import { MatSortModule } from '@angular/material/sort';
import { MatPaginatorModule } from '@angular/material/paginator';
import {MatButtonModule} from '@angular/material/button';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatDialogModule, MatDialogRef, MAT_DIALOG_DEFAULT_OPTIONS} from '@angular/material/dialog';
import { AddDepartmentComponent } from './components/add-department/add-department.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { AddTitleComponent } from './components/add-title/add-title.component';
import { AddPermitComponent } from './components/add-permit/add-permit.component';
import { AddPhonecallComponent } from './components/add-phonecall/add-phonecall.component';
import { AddMissionComponent } from './components/add-mission/add-mission.component';
import { MissionListComponent } from './components/mission-list/mission-list.component';


@NgModule({
  declarations: [
    AppComponent,
    SidenavComponent,
    CompanyComponent,
    DepartmentComponent,
    TitleComponent,
    EmployeeComponent,
    PhonecallComponent,
    PermitComponent,
    MissionComponent,
    AddDepartmentComponent,
    AddEmployeeComponent,
    AddTitleComponent,
    AddPermitComponent,
    AddPhonecallComponent,
    AddMissionComponent,
    MissionListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MatTableModule,
    MatSidenavModule,
    MatListModule,
    MatGridListModule,
    MatIconModule,
    MatToolbarModule,
    NgbModule,
    MatFormFieldModule,
    MatInputModule,
    MatSortModule,
    MatPaginatorModule,
    MatButtonModule,
    MatTooltipModule,
    MatDialogModule
  ],
  entryComponents: [
    DepartmentComponent,
    AddDepartmentComponent,
    TitleComponent,
    AddEmployeeComponent,
    AddTitleComponent,
    PermitComponent,
    AddPermitComponent,
    PhonecallComponent,
    AddPhonecallComponent,
    MissionComponent,
    MissionListComponent,
    AddMissionComponent
  ],
  providers: [
    { provide: MAT_FORM_FIELD_DEFAULT_OPTIONS, useValue: { appearance: 'legacy' } },
  ],
  bootstrap: [AppComponent, ]
})
export class AppModule { }
