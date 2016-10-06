using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface ICompanyService
    {
        Task<ICollection<Company>> LoadCompanies();
        Task<bool> SaveCompany(Company company);
        Task<bool> DeleteCompany(int companyID);        
    }
}
