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

        public DbSet<Story> Story { get; set; }

        public DbSet<Character> Character { get; set; }

        public DbSet<Scene> Scene { get; set; }
    }
}
