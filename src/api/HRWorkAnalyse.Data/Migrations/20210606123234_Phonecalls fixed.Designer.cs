﻿// <auto-generated />
using System;
using HRWorkAnalyse.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRWorkAnalyse.Data.Migrations
{
    [DbContext(typeof(HrWorkAnalyseDbContext))]
    [Migration("20210606123234_Phonecalls fixed")]
    partial class Phonecallsfixed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActiveYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnnualRepeatCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsMajor")
                        .HasColumnType("bit");

                    b.Property<string>("MissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MissionTime")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Permit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermitTime")
                        .HasColumnType("int");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Permits");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.PhoneCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("InCompany")
                        .HasColumnType("int");

                    b.Property<int>("OutCompany")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PhoneCalls");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("TitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Department", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Employee", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRWorkAnalyse.Entities.Entities.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Mission", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Title", "Title")
                        .WithMany("Missions")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Title");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Permit", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Employee", "Employee")
                        .WithMany("Permits")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRWorkAnalyse.Entities.Entities.Title", "Title")
                        .WithMany("Permits")
                        .HasForeignKey("TitleId");

                    b.Navigation("Employee");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.PhoneCall", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Employee", "Employee")
                        .WithMany("PhoneCalls")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Title", b =>
                {
                    b.HasOne("HRWorkAnalyse.Entities.Entities.Department", "Department")
                        .WithMany("Titles")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Company", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Employee", b =>
                {
                    b.Navigation("Permits");

                    b.Navigation("PhoneCalls");
                });

            modelBuilder.Entity("HRWorkAnalyse.Entities.Entities.Title", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Missions");

                    b.Navigation("Permits");
                });
#pragma warning restore 612, 618
        }
    }
}
