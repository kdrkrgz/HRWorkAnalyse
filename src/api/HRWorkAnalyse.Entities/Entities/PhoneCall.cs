using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRWorkAnalyse.Entities.Entities
{
    public class PhoneCall: IEntity
    {
        public int Id { get; set; }
        public int InCompany { get; set; }
        public int OutCompany {get; set;}
        public int EmployeeId { get; set; }

        public virtual Employee Employee {get;set;}
    }
}
