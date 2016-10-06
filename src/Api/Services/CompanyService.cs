using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
    public class CompanyService : ICompanyService
    {
        private DataContext _dbContext;

        public CompanyService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Company>> LoadCompanies()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<bool> SaveCompany(Company company)
        {
            var entry = _dbContext.Companies.Add(company);
            await _dbContext.SaveChangesAsync();

            return entry.State == EntityState.Added;
        }

        public async Task<bool> DeleteCompany(int companyID)
        {
            var company = await _dbContext.Companies.FirstAsync(m => m.CompanyID.Equals(companyID));

            var entry = _dbContext.Companies.Remove(company);
            await _dbContext.SaveChangesAsync();

            return entry.State == EntityState.Deleted;
        }
    }
}
