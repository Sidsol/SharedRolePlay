﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedRoleplay.Models;

namespace SharedRoleplay.Migrations
{
    [DbContext(typeof(SharedRoleplayContext))]
    [Migration("20190130172223_AddScenes")]
    partial class AddScenes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SharedRoleplay.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackStory");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EyeColor");

                    b.Property<string>("Gender");

                    b.Property<double>("Height");

                    b.Property<string>("HeirColor");

                    b.Property<string>("Languages");

                    b.Property<string>("Miscellaneous");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Race");

                    b.Property<string>("SexualOrientation");

                    b.Property<string>("Species");

                    b.Property<int?>("StoryID");

                    b.Property<double>("Weight");

                    b.HasKey("ID");

                    b.HasIndex("StoryID");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("SharedRoleplay.Models.Story", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Genre");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Story");
                });

            modelBuilder.Entity("SharedRoleplay.Models.Character", b =>
                {
                    b.HasOne("SharedRoleplay.Models.Story")
                        .WithMany("Characters")
                        .HasForeignKey("StoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
