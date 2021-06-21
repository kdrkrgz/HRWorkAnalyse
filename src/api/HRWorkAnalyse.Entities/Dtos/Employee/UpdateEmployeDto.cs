using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Employee
{
    public class UpdateEmployeDto: CreateEmployeeDto, IDto
    {
        public int Id { get; set; }
    }
}
