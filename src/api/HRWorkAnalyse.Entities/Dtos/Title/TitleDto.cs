using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.Title
{
    public class TitleDto: IDto
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public int DepartmentId { get; set; }
    }
}
