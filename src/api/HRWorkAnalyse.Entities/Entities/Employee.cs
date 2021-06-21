using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Employee: IEntity
    {
        public Employee()
        {
            PhoneCalls = new Collection<PhoneCall>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TitleId { get; set; }

        public virtual ICollection<PhoneCall> PhoneCalls {get;set;}
        public virtual Title Title { get; set; }
    }
}
