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
    [Migration("20230812210110_Attendance")]
    partial class Attendance
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
                            ConcurrencyStamp = "00f49803-fcd6-4cdf-bc49-74d319889132",
                            Name = "SuperUser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "d5023900-d15e-4402-9f2c-294153748243",
                            Name = "ProvincialAdmin",
                            NormalizedName = "PROVINCIALADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "92f6284b-c52f-4234-a498-128a1bf44878",
                            Name = "TroopScouter",
                            NormalizedName = "TROOPSCOUTER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "dd3d21bc-0ee2-42b7-a32a-90d38e769b41",
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
                            ConcurrencyStamp = "7964c580-ca2e-495b-b073-a7b1257fa1fc",
                            Email = "mpl.admin.ec@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsProvincialAdmin = true,
                            LastName = "EC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELf0Zh7mvZMGFmwIssLq1QludauowL5NoY30Rbh65HVgI6dM/1i580JczeKHMYrFYg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "223a4c2f-0244-4012-b5e7-1da2a47770a9",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.ec@gmail.com"
                        },
                        new
                        {
                            Id = "b2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce5102a1-37df-43dd-aac2-360ba8a03cd9",
                            Email = "mpl.admin.fs@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "FS",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA7mMWYyg+koWiGVWtNG0IKA0XmnNFLun9md8vbsXMpG7Fi2YK+pjH76oe+16mdzQw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "2",
                            SecurityStamp = "f016f1ed-a24b-46a8-91c4-c53843a37121",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.fs@gmail.com"
                        },
                        new
                        {
                            Id = "c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e573a765-1f95-40da-8099-6f0830330bc1",
                            Email = "mpl.admin.gp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "GP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAp/oxNamrMXskEpd7EtluYo6UtFEzHe2KsFVRJZGsnJeYR3+D5ObFfMlsjnKNP8fg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "3",
                            SecurityStamp = "c427453b-8087-4370-bb81-57b12787bef6",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.gp@gmail.com"
                        },
                        new
                        {
                            Id = "d4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9d5d1e4-3212-42a1-bd90-9a3a8ef465d3",
                            Email = "mpl.admin.kzn@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "KZN",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGEcoTCbKrXOXPykMEG6E6dqEB1GJkdCNcPwi88ruyhGJcZrukC0u9Rf/ZpMAfyltQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "4",
                            SecurityStamp = "a82f8be7-887d-4e5f-81e2-4ea307b6b6e8",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.kzn@gmail.com"
                        },
                        new
                        {
                            Id = "e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37a4f88a-e369-45c8-8aa9-b6779c0a683c",
                            Email = "mpl.admin.lp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "LP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHWKWBVOwTRx6bHfh6nFhlCka+q+qHf8k2rz+ilN1ygx4mVvxMmLowZyI+oi0Xt5jA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "5",
                            SecurityStamp = "2f1f4746-25de-4b98-972d-f2a5ef07d4df",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.lp@gmail.com"
                        },
                        new
                        {
                            Id = "f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7ba91ace-1de5-42f9-a727-33df105988ee",
                            Email = "mpl.admin.mp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "MP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED4Mm0IeEwbd5AptcY20eqneGSznfIxLN0YLkYxPFgD143vV5IGPplzaFH9ISoKxJw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "6",
                            SecurityStamp = "67004a74-ad96-4a30-aff1-f4b503046cfb",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.mp@gmail.com"
                        },
                        new
                        {
                            Id = "g7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7c23cb74-0428-4d89-8e01-bcc7f669bd36",
                            Email = "mpl.admin.nc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEG9T5gy+lZLiLU0KIxN3H4JXmHWhqrWqsi3FApmOFl8QOd5ItFkXcF4HW2VGa1xy7Q==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "7",
                            SecurityStamp = "41587955-cfe5-4b43-9f7b-d281912152b1",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nc@gmail.com"
                        },
                        new
                        {
                            Id = "h8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c682424-096f-4a59-b59c-f6f46bdaf9f4",
                            Email = "mpl.admin.nw@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NW",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ/7dBJmk+ArIb+nDA6PkNDF0slehDE3FBc8UVB8Y0ysU29961fr90+71dSSjybMNA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "8",
                            SecurityStamp = "abaa7cbc-ed9e-4f3a-b409-690e001bf29f",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nw@gmail.com"
                        },
                        new
                        {
                            Id = "i9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8badae12-409f-4806-8eba-4bbbe8a10727",
                            Email = "mpl.admin.wc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "WC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM08rTDXnsPiLAQVBvpEU7dS6Us+n0IXBo5zL4SsSM3lnctdpxdshkcwkOnP704xRw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "9",
                            SecurityStamp = "d4560644-5d3b-4f3d-8aca-3630a7e6fd0c",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.wc@gmail.com"
                        },
                        new
                        {
                            Id = "e3bbbab3-8fd6-4d34-99cd-da92c587f482",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d0a90826-f923-43f0-b205-04e1f2832bc9",
                            Email = "anushie@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anushie",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moon",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANUSHIE@GMAIL.COM",
                            NormalizedUserName = "ANUSHIE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHPhqv5vNxsc0gua5xNlcX4yN/eVIFAeHdlEHxfOHSX1hDfTZ9rdJIEDoQ84OJn0Uw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "f9676fda-3d6f-48ad-b900-fa09ce4e2527",
                            TwoFactorEnabled = false,
                            UserName = "anushie@gmail.com"
                        },
                        new
                        {
                            Id = "eb9647ac-8ec4-496e-be84-57f2c9d895a9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9425c395-5be0-4660-ae07-285b0d921331",
                            Email = "mishka@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mishka",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moony",
                            LockoutEnabled = false,
                            NormalizedEmail = "MISHKA@GMAIL.COM",
                            NormalizedUserName = "MISHKA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHBBD4kt5SO1ITL+Xf0jT59L7cmZKLFW0wXN/4UfBS/wE7eWjmfdcC6bkvoHaPQa7Q==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "07a1875c-920c-425b-90e3-ac6f4afbd3e7",
                            TwoFactorEnabled = false,
                            UserName = "mishka@gmail.com"
                        });
                });

            modelBuilder.Entity("MyPatrolLogbook.Models.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampId"), 1L, 1);

                    b.Property<int?>("CampCost")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CampDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("PatrolId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("VenueAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampId");

                    b.ToTable("Camps");
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