import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from 'src/app/models/employee';
import { Mission } from 'src/app/models/mission';
import { MissionDetail } from 'src/app/models/missionDetail';
import { Permit } from 'src/app/models/permit';
import { PhoneCall } from 'src/app/models/phoneCall';
import { Title } from 'src/app/models/title';
import { EmployeeService } from 'src/app/services/employee.service';
import { ExcelExportService } from 'src/app/services/excel-export.service';
import { MissionService } from 'src/app/services/mission.service';
import { PermitService } from 'src/app/services/permit.service';
import { PhonecallService } from 'src/app/services/phonecall.service';
import { TitleService } from 'src/app/services/title.service';



@Component({
  selector: 'app-mission',
  templateUrl: './mission.component.html',
  styleUrls: ['./mission.component.css']
})
export class MissionComponent implements OnInit {

  titleData: Title;
  missionDetailData: MissionDetail[];
  annualMissionTime: number;
  employeeData:Employee[];
  permitData: Permit[];
  totalPermitDays: number;
  phoneCallsData:PhoneCall[];
  totalPhoneCallTime: number;
  fixedAnnualMissionTime:number;

  constructor(private missionService: MissionService,
    private activatedRoute: ActivatedRoute,
    private employeeService: EmployeeService,
    private permitService: PermitService,
    private titleService: TitleService,
    private phoneCallService:PhonecallService,
    private excelService:ExcelExportService) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      this.getMissionsByTitle(params["titleId"])
      this.getEmployeesbyTitle(params["titleId"])
      this.getPermitsByTitle(params["titleId"])
      this.getTitle(params["titleId"])
    });
  }

  getMissionsByTitle(titleId: number) {
    this.missionService.GetMissionsByTitle(titleId).subscribe(response => {
      this.missionDetailData = response.data.map(x => ({
        totalTime: x.annualRepeatCount * x.missionTime,
        annualRepeatCount: x.annualRepeatCount,
        missionName: x.missionName,
        missionTime: x.missionTime,
        titleId: x.titleId,
        id: x.id
      }));
      this.getPhoneCallsByTitle(titleId) // burdan önce telefon yıllık telefon süreleri getiriliyor sonra yıllık iş yükü toplamına ekleniyor.
    })
  }


  getEmployeesbyTitle(titleId:number){
    this.employeeService.GetEmployeesByTitle(titleId).subscribe(response => {
      this.employeeData = response.data;
      
    });
  }

  getPermitsByTitle(titleId:number){
    this.permitService.GetPermitsByTitle(titleId).subscribe(response => {
      this.permitData = response.data;
      this.totalPermitDays = this.annualPermitSum(response.data)
    });
  }

  getPhoneCallsByTitle(titleId:number){
    this.phoneCallService.GetPhoneCallsByTitle(titleId).subscribe(response => {
      this.phoneCallsData = response.data;
      this.totalPhoneCallTime = this.annualPhoneCallSum(response.data)
      this.annualMissionTime = this.annualMissionSum(this.missionDetailData) + this.totalPhoneCallTime;
      this.fixedAnnualMissionTime = ((this.annualMissionTime * 0.9)*1.15)
    });
  }


  annualMissionSum(missionDetailData: MissionDetail[]) {
    let totalTime = 0
    for (let data of this.missionDetailData) {
      totalTime += data.totalTime
    }
    return totalTime;
  }

  annualPhoneCallSum(data:PhoneCall[]){
    let totalPhoneCallTime = 0
    for (let data of this.phoneCallsData) {
      totalPhoneCallTime += data.inCompany +  data.outCompany

    }
    return totalPhoneCallTime;
  }

  annualPermitSum(data:Permit[]){
    let totalPermitDays = 0
    for (let data of this.permitData) {
      totalPermitDays += data.permitTime

    }
    return totalPermitDays;
  }


  print(){
    window.print();
  }

  // ToDo: Refactor
  getTitle(titleId:number){
    this.titleService.GetTitle(titleId).subscribe(response => {
      this.titleData = response.data
    })
  }



  exportToExcel(){
    this.excelService.exportToExcel("export-excel", this.titleData.titleName)
  }


}
