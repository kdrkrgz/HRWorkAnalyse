using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Core.Entities.Concrete.Dtos
{
    public class PasswordResetDto: IDto
    {
        public string UserEmail { get; set; }
        public Guid Code { get; set; }
        public string Password { get; set; }
    }
}
