using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedRoleplay.Models;

namespace SharedRoleplay.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Story> Story { get; set; }

        public DbSet<Character> Character { get; set; }

        public DbSet<Scene> Scene { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<CharacterScene>()
                .HasKey(bc => new { bc.CharacterId, bc.SceneId });

            modelBuilder.Entity<CharacterScene>()
                .HasOne(bc => bc.Character)
                .WithMany(b => b.CharacterScenes)
                .HasForeignKey(bc => bc.CharacterId);

            modelBuilder.Entity<CharacterScene>()
                .HasOne(bc => bc.Scene)
                .WithMany(c => c.CharacterScenes)
                .HasForeignKey(bc => bc.SceneId);


        }
    }
}
