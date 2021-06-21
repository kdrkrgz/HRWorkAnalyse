using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRWorkAnalyse.Core.Data.EntityFramework;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Data.DbContexts;
using HRWorkAnalyse.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRWorkAnalyse.Data.Concrete.EntityFramework
{
    public class CompanyUserDal: EfEntityRepositoryBase<HrWorkAnalyseDbContext, CompanyUser>, ICompanyUserDal
    {
        private readonly HrWorkAnalyseDbContext _context;
        public CompanyUserDal(HrWorkAnalyseDbContext context) : base(context)
        {
            _context = context;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _context.UserOperationClaims
                .Include(u => u.User)
                .Include(oc => oc.OperationClaim)
                .AsNoTracking()
                .Where(x => x.UserId == user.Id)
                .Select(n => new OperationClaim
                {
                    Id= n.OperationClaimId,
                    Name = n.OperationClaim.Name
                }).ToList();
        }
    }
}
