using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Core.Entities.Concrete.Dtos
{
    public class UserForLoginDto: IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
