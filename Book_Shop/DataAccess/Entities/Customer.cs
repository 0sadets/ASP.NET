using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Customer : IdentityUser
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        ////public string Phone { get; set; }
        //public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
