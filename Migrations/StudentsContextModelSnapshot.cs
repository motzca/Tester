﻿// <auto-generated />
using FinalProject_CompProg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Proj.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    partial class StudentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject_CompProg.Models.Hobbies", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("avgTimeSpent")
                        .HasColumnType("int");

                    b.Property<string>("mainInterest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            id = 1,
                            activityType = "Active",
                            avgTimeSpent = 4,
                            mainInterest = "Graphical",
                            name = "Designing"
                        },
                        new
                        {
                            id = 2,
                            activityType = "Passive",
                            avgTimeSpent = 7,
                            mainInterest = "Thrillers",
                            name = "Reading"
                        },
                        new
                        {
                            id = 3,
                            activityType = "Active",
                            avgTimeSpent = 2,
                            mainInterest = "Soccer/Table Tennis",
                            name = "Club Sports"
                        });
                });

            modelBuilder.Entity("FinalProject_CompProg.Models.Music", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("artistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("musicGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("songTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Musicians");

                    b.HasData(
                        new
                        {
                            id = 1,
                            artistName = "Lovejoy",
                            musicGenre = "Indie Rock",
                            songTitle = "Taunt"
                        },
                        new
                        {
                            id = 2,
                            artistName = "The Crane Wives",
                            musicGenre = "American Folk Rock",
                            songTitle = "Tongues & Teeth"
                        },
                        new
                        {
                            id = 3,
                            artistName = "Scream Queen",
                            musicGenre = "Screamo",
                            songTitle = "Pretty In Pink"
                        });
                });

            modelBuilder.Entity("FinalProject_CompProg.Models.Restaurant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("foodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("founder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("foundingYear")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            id = 1,
                            foodType = "Burgers",
                            founder = "Richard McDonald and Maurice McDonald",
                            foundingYear = 1955,
                            name = "McDonalds"
                        },
                        new
                        {
                            id = 2,
                            foodType = "Burgers",
                            founder = "Dave Thomas",
                            foundingYear = 1969,
                            name = "Wendys"
                        },
                        new
                        {
                            id = 3,
                            foodType = "Spaghetti",
                            founder = "Bill Darden",
                            foundingYear = 1982,
                            name = "Olive Garden"
                        });
                });

            modelBuilder.Entity("FinalProject_CompProg.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("collegeProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("collegeYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            id = 1,
                            birthDate = "04/18/2001",
                            collegeProgram = "IT - Software Application",
                            collegeYear = "Junior",
                            fullName = "Chloe Motz"
                        },
                        new
                        {
                            id = 2,
                            birthDate = "12/28/2001",
                            collegeProgram = "IT - Game Development",
                            collegeYear = "Sophomore",
                            fullName = "Logan Arnett"
                        },
                        new
                        {
                            id = 3,
                            birthDate = "01/22/2002",
                            collegeProgram = "IT - Software Development and Technologies Track",
                            collegeYear = "Sophomore",
                            fullName = "Srishant Burdhan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
