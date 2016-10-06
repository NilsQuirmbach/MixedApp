using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IUserService
    {
        Task<ICollection<User>> GetCompanyUser(int companyID);
        Task<bool> SaveUser(User user);
        Task<bool> DeleteUser(int companyID, int userID);
    }
}
