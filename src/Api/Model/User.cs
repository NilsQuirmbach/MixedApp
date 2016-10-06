using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class User
    {
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
