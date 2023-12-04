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
    [Migration("20230809194617_PAupdate")]
    partial class PAupdate
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
                            ConcurrencyStamp = "9cc36d7a-e2f6-46fa-bb97-266b992cf02c",
                            Name = "SuperUser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "a4910d11-30a2-4e7f-b465-8a460b9cab49",
                            Name = "ProvincialAdmin",
                            NormalizedName = "PROVINCIALADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "4f1eb4a8-33c7-45e5-9e5c-93ed5d032105",
                            Name = "TroopScouter",
                            NormalizedName = "TROOPSCOUTER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "be8f81fe-daea-496b-9cd5-ef7834b3b8d0",
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

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "b27a9b52-509c-411d-976d-61451f9cb42b",
                            Email = "mpl.admin.ec@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsProvincialAdmin = true,
                            LastName = "EC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKvs4X7cbxaT2wb/hgjKgt0LyA5bA2HVx3o7IVxPcLevUcbyXNZkG+mlCKs4eSfD4g==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "03921946-2fa5-43e0-a9d0-f2b25c1ae732",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.ec@gmail.com"
                        },
                        new
                        {
                            Id = "b2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "467543e3-5df8-41e9-ab09-fbe762649c66",
                            Email = "mpl.admin.fs@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "FS",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMFWGui1I8GYAo0gA9G/rLvkJqPTKHqYNjln/4vsw16YltArZc9T/ZDJobX5+gGtCw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "2",
                            SecurityStamp = "e8a72673-e240-40bf-8a7e-c0967ccfaa3e",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.fs@gmail.com"
                        },
                        new
                        {
                            Id = "c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed974d97-2faa-4d38-88c3-42aaa168621a",
                            Email = "mpl.admin.gp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "GP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFNof9NrQhQG2h2jwZd095hnxh8nui3t1HHRI9sv2Oij0hQBfHqe8D8Cv0a+7IWVnQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "3",
                            SecurityStamp = "ca6a66a7-6638-4f2a-92a9-c898de7f435e",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.gp@gmail.com"
                        },
                        new
                        {
                            Id = "d4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3af59a1c-7189-42e2-ae94-b385172d83e1",
                            Email = "mpl.admin.kzn@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "KZN",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ4Nu2Zt8tLj6GKxoxU0fFVtfkbhDjLgbtNyQ2GNMAqX+f1ghWA0U/1sfQdxsM673Q==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "4",
                            SecurityStamp = "e21c028d-c916-4504-ab32-df2447e843cf",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.kzn@gmail.com"
                        },
                        new
                        {
                            Id = "e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0268c0c7-8a2d-4056-8f37-b60b2903add7",
                            Email = "mpl.admin.lp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "LP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHfs3wOi0mdXRWfOIofYMsc44b1nBluYuY5xnaxHs2a1Bha/sKC60y/321uaIpU8gQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "5",
                            SecurityStamp = "70b13835-8fc9-4935-85d1-57254800b660",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.lp@gmail.com"
                        },
                        new
                        {
                            Id = "f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aae201ad-1035-4589-b964-4678ae2a821e",
                            Email = "mpl.admin.mp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "MP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDLWTlkpj+YVyDEBNDFQftxR5xnnVsPcf14h5ZW0ocjjxjorHhc4gK86Kn8M0fMKNg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "6",
                            SecurityStamp = "053deacf-4eb5-4d9d-a765-55cf7fc1b5fb",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.mp@gmail.com"
                        },
                        new
                        {
                            Id = "g7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f744e2a-4365-4b02-88be-e0b675e99878",
                            Email = "mpl.admin.nc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEF5+UpmrrAE0NPWaLI5gZHReJ7NFN1DhFR/3CwmsFtbmvs2V9/FVfOCgNMQi43H8ZQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "7",
                            SecurityStamp = "dbfbb7cc-7588-4acc-ace7-7d0c76e02942",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nc@gmail.com"
                        },
                        new
                        {
                            Id = "h8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb0cb6c4-e546-49a7-9a54-5b0ce4f5da0c",
                            Email = "mpl.admin.nw@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NW",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJr7Xfyd+4R72HhB/YYL84PvP50fu8MveKd9OKyZE3dLHzYGiQsX+mtheIx4F0AT9A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "8",
                            SecurityStamp = "0f002f20-c18c-4efc-884b-3a7825039cb2",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nw@gmail.com"
                        },
                        new
                        {
                            Id = "i9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bfbf1e27-8f3a-4bc3-9802-2fca08417343",
                            Email = "mpl.admin.wc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "WC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBGDtawd+EtvZQV+ztz5kPkDi64byoRBj7vHyorWAhl/tIJMlYzFfBjH9Bqr9XIGmQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "9",
                            SecurityStamp = "27aa0fe7-815e-45f9-a586-c3e8bcd19c32",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.wc@gmail.com"
                        },
                        new
                        {
                            Id = "20aa3a6f-61d6-4179-96da-cecf5e0e0250",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "72a81cd5-f66e-45db-bfc2-a1f6d1ddb5f5",
                            Email = "anushie@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anushie",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moon",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANUSHIE@GMAIL.COM",
                            NormalizedUserName = "ANUSHIE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAb4bA92Vbh9MY7QGtj9IlmEntYD4tyHrsrITjYHRGovDMqweWM+Z5XXIsddhyYw4g==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "5e6f4799-12a0-4733-9b69-7509f078b5c2",
                            TwoFactorEnabled = false,
                            UserName = "anushie@gmail.com"
                        },
                        new
                        {
                            Id = "3100aeb1-2c09-4d9c-a170-53bcaf2dccac",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "965b1a5d-d40d-4bc0-b5a9-127f66c91c36",
                            Email = "mishka@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mishka",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moony",
                            LockoutEnabled = false,
                            NormalizedEmail = "MISHKA@GMAIL.COM",
                            NormalizedUserName = "MISHKA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDQ4QrPg0gha3gMkxubsNpxnq+17gpdlzGb2WiCwc76fzFyBV+wg9Ghj+4+aUOgkfQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "05b8201c-5407-4131-938f-b210acf5d970",
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
