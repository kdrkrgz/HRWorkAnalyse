using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Department: IEntity
    {
        public Department()
        {
            Employees = new Collection<Employee>();
            Titles = new Collection<Title>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int CompanyId { get; set; }

        // Navs
        public virtual Company Company { get; set; }
        public virtual ICollection<Title> Titles {get;set;}
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
