using HRWorkAnalyse.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Data.DbContexts.Configurations;

namespace HRWorkAnalyse.Data.DbContexts
{
    public class HrWorkAnalyseDbContext: DbContext
    {
        public HrWorkAnalyseDbContext(DbContextOptions<HrWorkAnalyseDbContext> options):base(options)
        {

        }

        public DbSet<Company> Companies {get;set;}
        public DbSet<Department> Departments {get;set;}
        public DbSet<Employee> Employees {get;set;}
        public DbSet<Mission> Missions {get;set;}
        public DbSet<Permit> Permits {get;set;}
        public DbSet<PhoneCall> PhoneCalls {get;set;}
        public DbSet<Title> Titles { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
