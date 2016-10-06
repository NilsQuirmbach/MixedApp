using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<User> CompanyUser { get; set; }
    }
}
