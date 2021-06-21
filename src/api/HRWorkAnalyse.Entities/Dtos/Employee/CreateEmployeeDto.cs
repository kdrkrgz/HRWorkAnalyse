using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Employee
{
    public class CreateEmployeeDto: IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TitleId { get; set; }
    }
}
