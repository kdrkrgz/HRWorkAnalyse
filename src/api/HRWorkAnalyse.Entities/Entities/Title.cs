using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Title: IEntity
    {
        public Title()
        {
            Missions = new Collection<Mission>();
            Permits = new Collection<Permit>();
            Employees = new Collection<Employee>();
        }
        public int Id { get; set; }
        public string TitleName { get; set; }
        public int DepartmentId { get; set; }

        public virtual ICollection<Mission> Missions {get;set;}
        public virtual ICollection<Permit> Permits {get;set;}
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Department Department { get; set; }
    }
}
