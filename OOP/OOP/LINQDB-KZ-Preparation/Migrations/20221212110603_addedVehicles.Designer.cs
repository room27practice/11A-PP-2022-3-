﻿// <auto-generated />
using System;
using LINQDB_KZ_Preparation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LINQDB_KZ_Preparation.Migrations
{
    [DbContext(typeof(SoftUniContext))]
    [Migration("20221212110603_addedVehicles")]
    partial class addedVehicles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeesProject", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeesProjects", (string)null);
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("AddressText")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("TownId")
                        .HasColumnType("int")
                        .HasColumnName("TownID");

                    b.HasKey("AddressId");

                    b.HasIndex("TownId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<int>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnName("ManagerID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("AddressID");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnName("ManagerID");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AddressId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("smalldatetime");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TownID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TownId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TownId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.UserVehicle", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("UserVehicles");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("EmployeesProject", b =>
                {
                    b.HasOne("LINQDB_KZ_Preparation.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesProjects_Employees");

                    b.HasOne("LINQDB_KZ_Preparation.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesProjects_Projects");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Address", b =>
                {
                    b.HasOne("LINQDB_KZ_Preparation.Models.Town", "Town")
                        .WithMany("Addresses")
                        .HasForeignKey("TownId")
                        .HasConstraintName("FK_Addresses_Towns");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Department", b =>
                {
                    b.HasOne("LINQDB_KZ_Preparation.Models.Employee", "Manager")
                        .WithMany("Departments")
                        .HasForeignKey("ManagerId")
                        .IsRequired()
                        .HasConstraintName("FK_Departments_Employees");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Employee", b =>
                {
                    b.HasOne("LINQDB_KZ_Preparation.Models.Address", "Address")
                        .WithMany("Employees")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_Employees_Addresses");

                    b.HasOne("LINQDB_KZ_Preparation.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Employees_Departments");

                    b.HasOne("LINQDB_KZ_Preparation.Models.Employee", "Manager")
                        .WithMany("InverseManager")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK_Employees_Employees");

                    b.Navigation("Address");

                    b.Navigation("Department");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.UserVehicle", b =>
                {
                    b.HasOne("LINQDB_KZ_Preparation.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleUsers")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LINQDB_KZ_Preparation.Models.Employee", "Employee")
                        .WithMany("UserVehicles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Address", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Employee", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("InverseManager");

                    b.Navigation("UserVehicles");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Town", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("LINQDB_KZ_Preparation.Models.Vehicle", b =>
                {
                    b.Navigation("VehicleUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
