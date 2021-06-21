import { Injectable } from '@angular/core';
import * as XLSX from 'xlsx';

@Injectable({
  providedIn: 'root'
})
export class ExcelExportService {

constructor() { }

exportToExcel(className:string, fileName:string){
  let elements = document.getElementsByClassName(className)[0];
  // for (let i = 0; i < elements.length; i++) {
  //   console.log("element", elements[i] );
  let formattedFileName = this.formatFileName(fileName)
  // TODO: for loop elements
  // }
  const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(elements);
  const wb: XLSX.WorkBook = XLSX.utils.book_new();
  XLSX.utils.book_append_sheet(wb, ws, "Sheet1");
  XLSX.writeFile(wb, formattedFileName)

}

formatFileName(title:string){
  return title+"-"+new Date().getFullYear().toString()+".xlsx"
}
}
