﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Core.Entities.Concrete
{
    public class User: IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Status { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
