﻿// <auto-generated />
using System;
using HrPayroll.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HrPayroll.Migrations
{
    [DbContext(typeof(PayrollDbContext))]
    [Migration("20191004084604_changepositionrol")]
    partial class changepositionrol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status");

                    b.Property<string>("UniversityFaculty")
                        .IsRequired();

                    b.Property<string>("UniversityName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.EmployeeChangePositionRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<bool>("CalcSalary");

                    b.Property<string>("Company");

                    b.Property<string>("Emporium");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("ChangePositionRols");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MaritalStatuses");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.OldWorkPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("date");

                    b.Property<string>("WorkCompany");

                    b.Property<string>("WorkPosition");

                    b.Property<string>("WorkStatus");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("OldWorkPlaces");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.AbsentCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AbsentCounts");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Bonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<DateTime>("BonusDate");

                    b.Property<decimal>("BonusPrize");

                    b.Property<string>("BonusStatus")
                        .IsRequired();

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Bonus");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HoldingId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("HoldingId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HoldingId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("HoldingId");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.DisciplinePenalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxDay");

                    b.Property<int>("MinDay");

                    b.Property<int>("PenaltyValue");

                    b.HasKey("Id");

                    b.ToTable("DisciplinePenalties");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Dismissed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictRegistration");

                    b.Property<string>("Email");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("IDCardSerialNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<string>("Photo");

                    b.Property<string>("PlasiyerCode");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Dismisseds");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("DistrictRegistration")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<DateTime>("IDCardExparyDate")
                        .HasColumnType("date");

                    b.Property<string>("IDCardSerialNumber")
                        .IsRequired();

                    b.Property<string>("MaritalStatus")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nationally")
                        .IsRequired();

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Photo");

                    b.Property<string>("PlasiyerCode")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmployeeSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PositionsId");

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("PositionsId");

                    b.ToTable("EmployeeSalaries");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Emporium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Emporia");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmporiumAppUserMenecer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<int>("EmporiumId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("EmporiumId");

                    b.ToTable("EmporiumAppUsers");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmporiumPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmporiumId");

                    b.Property<int>("PositionsId");

                    b.HasKey("Id");

                    b.HasIndex("EmporiumId");

                    b.HasIndex("PositionsId");

                    b.ToTable("EmporiumPositions");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Holding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Holdings");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.MessageReciurment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("FirstName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SecondName");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("MessageReciurments");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.OficeEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<DateTime>("StarDate");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("OficeEmployees");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.OficeSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleManagerId")
                        .IsRequired();

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.ToTable("OficeSalaries");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Positions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.PositionsDepartament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentId");

                    b.Property<int>("PositionsId");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.HasIndex("PositionsId");

                    b.ToTable("PositionsDepartaments");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.SignInOutReasonTbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<decimal>("PenaltyAmount");

                    b.Property<string>("RaasonName")
                        .IsRequired();

                    b.Property<bool>("SignIn");

                    b.Property<DateTime>("SignInTime");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SignInOutReasons");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.VacationEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CalcSalary");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StarDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("VacationEmployees");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.WorkEndDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsCalcDate");

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkEnds");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.WorkPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<int>("EmporiumId");

                    b.Property<int>("PositionsId");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmporiumId");

                    b.HasIndex("PositionsId");

                    b.ToTable("Placeswork");
                });

            modelBuilder.Entity("HrPayroll.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Adress");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo");

                    b.Property<string>("SecondName")
                        .IsRequired();

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.Education", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("Educations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.EmployeeChangePositionRol", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.EmployeeModel.OldWorkPlace", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("OldWorkPlaces")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.AbsentCount", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("AbsentCounts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Bonus", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("Bonus")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Company", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Holding", "Holding")
                        .WithMany("Companies")
                        .HasForeignKey("HoldingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Departament", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Holding", "Holding")
                        .WithMany()
                        .HasForeignKey("HoldingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmployeeSalary", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Positions", "Positions")
                        .WithMany("EmployeeSalaries")
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Emporium", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Company", "Company")
                        .WithMany("Emporia")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmporiumAppUserMenecer", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("HrPayroll.Areas.Admin.Models.Emporium", "Emporium")
                        .WithMany()
                        .HasForeignKey("EmporiumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.EmporiumPosition", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Emporium", "Emporium")
                        .WithMany("EmporiumPositions")
                        .HasForeignKey("EmporiumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayroll.Areas.Admin.Models.Positions", "Positions")
                        .WithMany("EmporiumPositions")
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.MessageReciurment", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.OficeEmployee", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.Penalty", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("Penalties")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.PositionsDepartament", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Departament", "Departament")
                        .WithMany("PositionDepartaments")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayroll.Areas.Admin.Models.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.SignInOutReasonTbl", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("SignInOutReasonTbls")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.VacationEmployee", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("VacationEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.WorkEndDate", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("WorkEndDates")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HrPayroll.Areas.Admin.Models.WorkPlace", b =>
                {
                    b.HasOne("HrPayroll.Areas.Admin.Models.Employee", "Employee")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayroll.Areas.Admin.Models.Emporium", "Emporium")
                        .WithMany()
                        .HasForeignKey("EmporiumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayroll.Areas.Admin.Models.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPayroll.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HrPayroll.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
