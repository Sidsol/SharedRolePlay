using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedRoleplay.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Story> Stories { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
