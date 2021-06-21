using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Permit: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermitTime {get;set;}
        public int TitleId { get; set; }

        public virtual Title Title {get;set; }
    }
}
