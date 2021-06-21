import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/models/company';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {

  CompanyData:Company[] | undefined;


  constructor(private companyService:CompanyService) { }

  ngOnInit() {
    this.companyService.GetCompanies().subscribe(response => {
      this.CompanyData = response.data as Company[];
      console.log("companies :",response.data);
      
    });
  }
}
