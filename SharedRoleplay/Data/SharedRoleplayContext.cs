using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharedRoleplay.Models;

namespace SharedRoleplay.Models
{
    public class SharedRoleplayContext : DbContext
    {
        public SharedRoleplayContext (DbContextOptions<SharedRoleplayContext> options)
            : base(options)
        {
        }

        public DbSet<SharedRoleplay.Models.Story> Story { get; set; }

        public DbSet<SharedRoleplay.Models.Character> Character { get; set; }
    }
}
