using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Company
{
    public class CreateCompanyDto: IDto
    {
        public string CompanyName { get; set; }
        public string Description { get; set; }
    }
}
