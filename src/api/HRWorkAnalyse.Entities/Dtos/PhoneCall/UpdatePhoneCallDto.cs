using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities;

namespace HRWorkAnalyse.Entities.Dtos.PhoneCall
{
    public class UpdatePhoneCallDto: CreatePhoneCallDto, IDto
    {
        public int Id { get; set; }
    }
}
