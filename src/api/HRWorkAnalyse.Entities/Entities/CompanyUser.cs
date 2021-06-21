using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;

namespace HRWorkAnalyse.Entities.Entities
{
    [NotMapped]
    public class CompanyUser: User
    {
        public Guid CompanyUserGuid { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
