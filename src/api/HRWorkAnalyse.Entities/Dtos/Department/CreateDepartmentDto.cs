using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Department
{
    public class CreateDepartmentDto: IDto
    {
        public string DepartmentName { get; set; }
        public int CompanyId { get; set; }
    }
}
