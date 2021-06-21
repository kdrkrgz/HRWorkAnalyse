using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRWorkAnalyse.Entities.Dtos.Company
{
    public class UpdateCompanyDto: CreateCompanyDto, IDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
