using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class Employee : IdentityUser // refers to table - AspnetUsers
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }

        public DateTime DateCreated { get; set; }


    }
}
