using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SharedRoleplay.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SharedRoleplayContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SharedRoleplayContext>>()))
            {
                // Look for any movies.
                if (context.Character.Any())
                {
                    return;   // DB has been seeded
                }

                context.Character.AddRange(
                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
