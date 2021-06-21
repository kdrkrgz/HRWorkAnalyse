using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Permit
{
    public class UpdatePermitDto: CreatePermitDto, IDto
    {        
        public int Id { get; set; }
    }
}
