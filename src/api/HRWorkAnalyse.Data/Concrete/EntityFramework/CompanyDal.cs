using HRWorkAnalyse.Core.Data.EntityFramework;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Data.DbContexts;
using HRWorkAnalyse.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Data.Concrete.EntityFramework
{
    public class CompanyDal : EfEntityRepositoryBase<HrWorkAnalyseDbContext, Company>, ICompanyDal
    {
        public CompanyDal(HrWorkAnalyseDbContext context):base(context)
        {

        }
    }
}
