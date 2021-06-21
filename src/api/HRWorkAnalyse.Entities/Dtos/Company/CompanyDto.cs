using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Entities.Dtos.Company
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
