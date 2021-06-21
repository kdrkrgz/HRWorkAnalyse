using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Permit
{
    public class CreatePermitDto: IDto
    {
        public string Name { get; set; }
        public int PermitTime {get;set;}
        public int TitleId { get; set; }
    }
}
