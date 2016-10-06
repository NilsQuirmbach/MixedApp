using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        protected ICompanyService CompanyService { get; private set; }

        public CompanyController(ICompanyService companyService)
        {
            CompanyService = companyService;
        }


        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
        {
            return await CompanyService.LoadCompanies();
        }
        
        [HttpPost]
        public async Task Post([FromBody]Company company)
        {
            await CompanyService.SaveCompany(company);
        }
        
        [HttpDelete("{companyID}")]
        public async Task Delete(int companyID)
        {
            await CompanyService.DeleteCompany(companyID);
        }
    }
}
