using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.PhoneCall
{
    public class PhoneCallDto: IDto
    {
        public int Id { get; set; }
        public int InCompany { get; set; }
        public int OutCompany {get; set;}
        public int EmployeeId { get; set; }
    }
}
