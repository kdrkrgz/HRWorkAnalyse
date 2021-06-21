using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Mission
{
    public class MissionDto: IDto
    {
        public int Id { get; set; }
        public string MissionName { get; set; }
        public int? AnnualRepeatCount { get; set; }
        public int? MissionTime { get; set; }
        public int TitleId { get; set; }
    }
}
