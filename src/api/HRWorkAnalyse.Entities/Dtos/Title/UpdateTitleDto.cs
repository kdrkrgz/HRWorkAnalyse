using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Title
{
    public class UpdateTitleDto: CreateTitleDto, IDto
    {
        public int Id { get; set; }
    }
}
