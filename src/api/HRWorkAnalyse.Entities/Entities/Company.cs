using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Company: IEntity
    {
        public Company()
        {
            Departments = new Collection<Department>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime ActiveYear {get;set;}
        
        public bool IsActive { get; set; }

        // Navs
        public virtual ICollection<Department> Departments {get;set;}
    }
}
