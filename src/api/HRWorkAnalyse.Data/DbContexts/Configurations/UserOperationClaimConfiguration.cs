using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRWorkAnalyse.Data.DbContexts.Configurations
{
    public class UserOperationClaimConfiguration: IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(fk => new { fk.UserId, fk.OperationClaimId });
        }
    }
}
