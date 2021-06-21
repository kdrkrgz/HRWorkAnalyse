using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Core.Entities.Concrete.Dtos
{
    public class AccountActivateDto: IDto
    {
        public string UserEmail { get; set; }
        public Guid Code { get; set; }
    }
}
