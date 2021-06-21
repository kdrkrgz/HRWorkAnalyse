using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Mission
{
    public class UpdateMissionDto : CreateMissionDto, IDto
    {
        public int Id { get; set; }
    }
}
