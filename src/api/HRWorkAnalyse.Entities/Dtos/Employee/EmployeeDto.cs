using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Employee
{
    public class EmployeeDto: IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
