using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Department
{
    public class DepartmentDto: IDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int CompanyId { get; set; }
    }
}
