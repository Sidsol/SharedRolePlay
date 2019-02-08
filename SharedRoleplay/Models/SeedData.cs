using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SharedRoleplay.Data;
using System;
using System.Linq;

namespace SharedRoleplay.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Characters.
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
                        Weight = 135,
                        ApplicationUserId = "1"
                       
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135,
                        ApplicationUserId = "1"
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135,
                        ApplicationUserId = "1"
                    },

                    new Character
                    {
                        Name = "Jane Doe",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Height = 5.9,
                        Weight = 135,
                        ApplicationUserId = "1"
                    }
                );
                context.SaveChanges();

                // Look for any Stories.
                if (context.Story.Any())
                {
                    return;   // DB has been seeded
                }

                context.Story.AddRange(
                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational" 
                    },

                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational"
                    },
                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational"
                    },
                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational"
                    },
                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational"
                    },
                    new Story
                    {
                        Title = "Jane Doe",
                        Genre = "Inspirational"
                    }
                );

                if (context.Scene.Any())
                {
                    return;
                }

                context.Scene.AddRange(
                    new Scene
                    {
                        Name = "Act 1",
                        Setting = "Place 1",
                        StoryID = 1
                    },
                    new Scene
                    {
                        Name = "Act 2",
                        Setting = "Place 2",
                        StoryID = 1
                    },
                    new Scene
                    {
                        Name = "Act 3",
                        Setting = "Place 3",
                        StoryID = 1
                    },
                    new Scene
                    {
                        Name = "Act 4",
                        Setting = "Place 4",
                        StoryID = 1
                    },
                                        new Scene
                                        {
                                            Name = "Act 1",
                                            Setting = "Place 1",
                                            StoryID = 2
                                        },
                    new Scene
                    {
                        Name = "Act 2",
                        Setting = "Place 2",
                        StoryID = 2
                    },
                    new Scene
                    {
                        Name = "Act 3",
                        Setting = "Place 3",
                        StoryID = 2
                    },
                    new Scene
                    {
                        Name = "Act 4",
                        Setting = "Place 4",
                        StoryID = 2
                    }
                );

            }
        }
    }
}
