using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
    public class UserService : IUserService
    {
        private DataContext _dbContext;

        public UserService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<User>> GetCompanyUser(int companyID)
        {
            return await _dbContext.User.Where(m => m.CompanyID.Equals(companyID)).ToListAsync();
        }

        public async Task<bool> SaveUser(User user)
        {
            var userEntry = _dbContext.User.Add(user);
            await _dbContext.SaveChangesAsync();

            return userEntry.State == EntityState.Added;
        }

        public async Task<bool> DeleteUser(int companyID, int userID)
        {
            var user = await _dbContext.User.FirstAsync(m => m.CompanyID.Equals(companyID) && m.UserID.Equals(userID));            

            var userEntry = _dbContext.User.Remove(user);
            await _dbContext.SaveChangesAsync();

            return userEntry.State == EntityState.Deleted;
        }
    }
}
