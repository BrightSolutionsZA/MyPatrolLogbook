﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPatrolLogbook.Models;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230809200256_bdayUpdate")]
    partial class bdayUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "658325ac-ee18-4aec-9d4b-1485a07a2c54",
                            Name = "SuperUser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "8afb6336-12fb-4ebb-aa26-ce437a0e08bd",
                            Name = "ProvincialAdmin",
                            NormalizedName = "PROVINCIALADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "1f1abd84-0132-4bfe-8217-daafe5f9c880",
                            Name = "TroopScouter",
                            NormalizedName = "TROOPSCOUTER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "7e6e6929-78df-41ed-8305-813f87f8749c",
                            Name = "Scout",
                            NormalizedName = "SCOUT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a1",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "b2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "c3",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "d4",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "e5",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "f6",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "g7",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "h8",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "i9",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyPatrolLogbook.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CellNumber")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAdvancementAchieved")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("HasAttendedTraining")
                        .HasColumnType("bit");

                    b.Property<bool?>("HasNationalChallenge")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPatrolLeader")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsProvincialAdmin")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsTroopScouter")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("NumDiscovererTheme")
                        .HasColumnType("int");

                    b.Property<int?>("NumFirstClassTheme")
                        .HasColumnType("int");

                    b.Property<int?>("NumSpringbokTheme")
                        .HasColumnType("int");

                    b.Property<int?>("NumTravellerTheme")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatrolId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatrolJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProvinceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TroopId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bbc9a333-1dff-4015-b21d-17c6ee9a4d90",
                            Email = "mpl.admin.ec@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsProvincialAdmin = true,
                            LastName = "EC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJnsPI1+Fz6WKvyi3yH/R6YmfGIpnpt3W5SLXKspJRoMwojUWZMnCrMm1po+SkQ5vQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "b43f7203-23a5-4a73-b638-e9aed7020990",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.ec@gmail.com"
                        },
                        new
                        {
                            Id = "b2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91428f68-dab4-4f0d-826d-043502539a03",
                            Email = "mpl.admin.fs@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "FS",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJbOnRRfjekyeFN/EkNLTeBnnYAOCbg9WPtSqdCMvoFtZkJ5AisPkUjg5C2K8KB59A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "2",
                            SecurityStamp = "06cbc2cc-8273-4c2a-9d2f-c6eff41dc3f6",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.fs@gmail.com"
                        },
                        new
                        {
                            Id = "c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d88ebaa-2d9c-4d9f-862f-5bcf3f394c0b",
                            Email = "mpl.admin.gp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "GP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECEB/E0+H/cuw6st3aruop6lY6emtuhKfw+jDVWBwmLqEue3aHkTrb5F86Q5i4UMvg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "3",
                            SecurityStamp = "b27e3eb9-1f42-4b66-b39d-6e5632e4421a",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.gp@gmail.com"
                        },
                        new
                        {
                            Id = "d4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8c4ba42f-6500-4047-a78d-65eca3a3242e",
                            Email = "mpl.admin.kzn@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "KZN",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIXTxDAFZQjRHKfpzDYOWBRbDDSXVLPe2e0fn/RA7TmHaMBRlObMOZtAdVesm+wknQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "4",
                            SecurityStamp = "d7536073-e29f-4b00-af92-f2439423f614",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.kzn@gmail.com"
                        },
                        new
                        {
                            Id = "e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc9f31f2-62c8-49a8-89fe-4db120ed48c6",
                            Email = "mpl.admin.lp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "LP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJyZV2g47n1Ka7FwW8vprMf/PTDT3UtkX/wYXz1HOhgDmkKvxyMj15lPyHyfik+cdA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "5",
                            SecurityStamp = "3422af24-1994-48bf-ba50-44a22206fd1b",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.lp@gmail.com"
                        },
                        new
                        {
                            Id = "f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "98346cec-baf4-438a-abba-dd593a9f1cb2",
                            Email = "mpl.admin.mp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "MP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELipCgsue05sk0swYBwgoxxoJF06dhO3675+tB8E+wgfZ6ygv7hv5oXbUxkeaXQzaw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "6",
                            SecurityStamp = "98cd2142-4923-46d3-8ffe-223d2fe03469",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.mp@gmail.com"
                        },
                        new
                        {
                            Id = "g7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34003cc8-a84b-41b0-a5a7-9a62edb1c8b2",
                            Email = "mpl.admin.nc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAyywrqoslse79431cAc+Ow52hHU8ex9OEerITt1h6Ol9EoBaxHr0WVAWSlZYcKoZA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "7",
                            SecurityStamp = "801e2d0a-52c5-4157-864b-f2dd975dbd3c",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nc@gmail.com"
                        },
                        new
                        {
                            Id = "h8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fefec7fb-2558-493c-88eb-5d977ec46e7d",
                            Email = "mpl.admin.nw@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NW",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPJpx4lq0oGWC5dRLs1a36y9kGCS4zuRI87+lK5BCJ80XHqCpVx81e3+NQB8nhvLpQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "8",
                            SecurityStamp = "33d0d72a-d6ef-41d1-b2b1-708971ffe06d",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nw@gmail.com"
                        },
                        new
                        {
                            Id = "i9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a3074413-4202-4338-8657-001e455edcbd",
                            Email = "mpl.admin.wc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "WC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDS/rdLy29Fdo/BpcG5C40HwD9m+SlK9dBlM/e/MJHL4zmuzM9eUlQkP+xMzP5eFZQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "9",
                            SecurityStamp = "150d6556-e73d-40bf-8354-043aed5ea755",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.wc@gmail.com"
                        },
                        new
                        {
                            Id = "e8f6a82b-3746-4553-9eda-ea9bccb0dfe9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca988e65-1af4-4320-95b2-edfb118d6eae",
                            Email = "anushie@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anushie",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moon",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANUSHIE@GMAIL.COM",
                            NormalizedUserName = "ANUSHIE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJdASG0KG+IO5EAgxVp7uTvubi2YIv8B95Fhqi2EY7cWV/OvRxScncI2ZXjgXN0NMw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "bc3ca6c7-2c84-4aff-bdbf-de1a62f259ef",
                            TwoFactorEnabled = false,
                            UserName = "anushie@gmail.com"
                        },
                        new
                        {
                            Id = "42da64d4-c80f-4758-9a9b-3deb92f79801",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d1d3062-666b-4da3-9263-2750ce529226",
                            Email = "mishka@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mishka",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moony",
                            LockoutEnabled = false,
                            NormalizedEmail = "MISHKA@GMAIL.COM",
                            NormalizedUserName = "MISHKA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAh5UNy6chAWR8ONG1V5sUyV4w54ep3RlxybqbQVh2hkV9HLcZVVTVwxJj9ZWza0TQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "61758d6b-1084-4c5e-85d9-7a2d569ec0ae",
                            TwoFactorEnabled = false,
                            UserName = "mishka@gmail.com"
                        });
                });

            modelBuilder.Entity("MyPatrolLogbook.Models.Patrol", b =>
                {
                    b.Property<int>("PatrolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatrolId"), 1L, 1);

                    b.Property<string>("PatrolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TroopId")
                        .HasColumnType("int");

                    b.HasKey("PatrolId");

                    b.ToTable("Patrols");
                });

            modelBuilder.Entity("MyPatrolLogbook.Models.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinceId"), 1L, 1);

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            ProvinceId = 1,
                            ProvinceName = "Eastern Cape"
                        },
                        new
                        {
                            ProvinceId = 2,
                            ProvinceName = "Free State"
                        },
                        new
                        {
                            ProvinceId = 3,
                            ProvinceName = "Gauteng"
                        },
                        new
                        {
                            ProvinceId = 4,
                            ProvinceName = "KwaZulu-Natal"
                        },
                        new
                        {
                            ProvinceId = 5,
                            ProvinceName = "Limpopo"
                        },
                        new
                        {
                            ProvinceId = 6,
                            ProvinceName = "Mpumalanga"
                        },
                        new
                        {
                            ProvinceId = 7,
                            ProvinceName = "Northern Cape"
                        },
                        new
                        {
                            ProvinceId = 8,
                            ProvinceName = "North West"
                        },
                        new
                        {
                            ProvinceId = 9,
                            ProvinceName = "Western Cape"
                        });
                });

            modelBuilder.Entity("MyPatrolLogbook.Models.Troop", b =>
                {
                    b.Property<int>("TroopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TroopId"), 1L, 1);

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("TroopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TroopId");

                    b.ToTable("Troops");

                    b.HasData(
                        new
                        {
                            TroopId = 1,
                            ProvinceId = 4,
                            TroopName = "57th Trafalgar Sea Scout Group"
                        },
                        new
                        {
                            TroopId = 2,
                            ProvinceId = 9,
                            TroopName = "2nd Rondebosch Scout Group"
                        },
                        new
                        {
                            TroopId = 3,
                            ProvinceId = 8,
                            TroopName = "1st Ikageng Scout Group"
                        },
                        new
                        {
                            TroopId = 4,
                            ProvinceId = 7,
                            TroopName = "1st Isago Scout Group"
                        },
                        new
                        {
                            TroopId = 5,
                            ProvinceId = 6,
                            TroopName = "1st Nelspruit Scout Group"
                        },
                        new
                        {
                            TroopId = 6,
                            ProvinceId = 5,
                            TroopName = "1st Polokwane Scout Group"
                        },
                        new
                        {
                            TroopId = 7,
                            ProvinceId = 4,
                            TroopName = "4th Durban Scout Group"
                        },
                        new
                        {
                            TroopId = 8,
                            ProvinceId = 3,
                            TroopName = "1st Bryanston Scout Group"
                        },
                        new
                        {
                            TroopId = 9,
                            ProvinceId = 2,
                            TroopName = "1st Qwaqwa Scout Group"
                        },
                        new
                        {
                            TroopId = 10,
                            ProvinceId = 1,
                            TroopName = "1st Vincent Scout Group"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyPatrolLogbook.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyPatrolLogbook.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyPatrolLogbook.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyPatrolLogbook.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}