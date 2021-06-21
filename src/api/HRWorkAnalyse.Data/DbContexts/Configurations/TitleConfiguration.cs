using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRWorkAnalyse.Data.DbContexts.Configurations
{
    public class TitleConfiguration: IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasOne(u => u.Department).WithMany(d => d.Titles).HasForeignKey(f => f.DepartmentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
