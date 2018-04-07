using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using static Pollster_v4.Models.Enums;

namespace Pollster_v4.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    { 
        public string PostalCode { get; set; }
        public Education? Education { get; set; }
        public Gender? Gender { get; set; }
        public Income? Income { get; set; }
        public Religion? Religion { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public Politics? Politics { get; set; }
    }
}
