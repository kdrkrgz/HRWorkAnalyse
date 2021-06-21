using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Permit
{
    public class PermitDto: IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermitTime {get;set;}
    }
}
