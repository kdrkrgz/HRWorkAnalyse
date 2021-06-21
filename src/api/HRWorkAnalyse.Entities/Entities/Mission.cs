using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Entities.Entities
{
    public class Mission: IEntity
    {
        public int Id { get; set; }
        public string MissionName { get; set; }
        public int? AnnualRepeatCount { get; set; }
        public int? MissionTime { get; set; }
        public int TitleId { get; set; }

        public bool IsMajor {get;set;}

        public virtual Title Title {get;set;}
    }
}
