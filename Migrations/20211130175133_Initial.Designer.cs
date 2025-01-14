﻿// <auto-generated />
using FinalProject_CompProg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Proj.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20211130175133_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            collegeProgram = "IT -Game Development",
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
