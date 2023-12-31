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
    [Migration("20230812133012_CampCostFix")]
    partial class CampCostFix
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
                            ConcurrencyStamp = "59c1ccbc-93b0-46b9-b8fd-5821a9cfc013",
                            Name = "SuperUser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "810cba5d-8108-49cc-9e48-7dd401435d70",
                            Name = "ProvincialAdmin",
                            NormalizedName = "PROVINCIALADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "a0fce821-66b9-42b9-840c-5b511e2420f2",
                            Name = "TroopScouter",
                            NormalizedName = "TROOPSCOUTER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "a2094b46-43f6-4c5a-9390-22ffce7e40df",
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
                            ConcurrencyStamp = "15bb508e-7a1f-4c34-b67d-8859446014c8",
                            Email = "mpl.admin.ec@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsProvincialAdmin = true,
                            LastName = "EC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAwlhERI7KIKg/a8vQvmGBC9c8ty3Bwl9lr8U5a/MWEwfenQB425RKvVhU9oyuSEww==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "762c77d2-740c-427e-827c-4ea7e19a8a89",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.ec@gmail.com"
                        },
                        new
                        {
                            Id = "b2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "459494d4-909f-4c72-9a7b-39ecc3d61821",
                            Email = "mpl.admin.fs@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "FS",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOyXkjRG77cFCWCzaYIuTFI7mr4DUsh82xLQrFcUqRVJEq6mQ+8IpUHubtRDbHh76A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "2",
                            SecurityStamp = "c5f83190-a78f-4e57-ba08-63052746f217",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.fs@gmail.com"
                        },
                        new
                        {
                            Id = "c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "81d0519a-c0f8-46d5-8e06-2a6cad2234f5",
                            Email = "mpl.admin.gp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "GP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEmQbNkDnyGkNAy3wWenlVILFsC/Ot3HBWQfTfwX66CZAD5rED5FBz9qag4gCjGThg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "3",
                            SecurityStamp = "e021bca2-6978-49fe-9198-7fb6284fc3db",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.gp@gmail.com"
                        },
                        new
                        {
                            Id = "d4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "556661db-31d7-466c-9a71-88336e059991",
                            Email = "mpl.admin.kzn@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "KZN",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBvxixwl0JjIql12ls0ZTwb27o/k8QQxJhC/JYroruDUkLdsCshVebDKNtA/LgwG/g==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "4",
                            SecurityStamp = "4c71afe3-bf62-45be-b48c-8b558571e2c2",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.kzn@gmail.com"
                        },
                        new
                        {
                            Id = "e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b2067e43-b5e2-4db1-9ace-b8aed63ff2bb",
                            Email = "mpl.admin.lp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "LP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED542AdX5if7mtGApkTHk2TRZi899xnQDtgs3AFRHmCnJZri+CNi4OsV+mFAtCL+mg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "5",
                            SecurityStamp = "66da3a98-13df-4623-9a3a-e7008ebc491d",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.lp@gmail.com"
                        },
                        new
                        {
                            Id = "f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5e665d0c-633d-4ba0-a831-536890f1d3db",
                            Email = "mpl.admin.mp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "MP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEUNixiMHAS9oxHfkgsEApW2b90+25j1DzHLSktUjCsSiT1NzWyLZxr0h0bSwd5rjA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "6",
                            SecurityStamp = "92443e63-96bc-4d85-96de-ff614855dd06",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.mp@gmail.com"
                        },
                        new
                        {
                            Id = "g7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5b527fcd-1d9a-4a26-9bad-9968c3066516",
                            Email = "mpl.admin.nc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFXLGcE6pTs9CKlDqjLfrhfISTnP/FADkNh1T2D689c2Qkt/Z5SlZozcxtB1UT2Z7w==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "7",
                            SecurityStamp = "fa4e08bd-1aea-4350-8784-bbebe5a38d45",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nc@gmail.com"
                        },
                        new
                        {
                            Id = "h8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "935f3b7f-69e5-4542-83e0-3cf68fce3b20",
                            Email = "mpl.admin.nw@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NW",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGv7x7FhTrwqUOJdy4djcdc274k8YfPe88SXVXyx/5xL+2K/CZYulo9ejryuvpgB4w==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "8",
                            SecurityStamp = "ae85dd05-2348-4531-b633-04d091d96fce",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nw@gmail.com"
                        },
                        new
                        {
                            Id = "i9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0dcc7c4-64db-49d6-bede-db12eb65faf6",
                            Email = "mpl.admin.wc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "WC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECelS84/3euPNnuifus/LWQa8Ztk8n+jbck/mcXXkpEa/kAHzIrcniOloiViNkCPMw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "9",
                            SecurityStamp = "f4e49802-862d-4129-ba7e-52735256e4a5",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.wc@gmail.com"
                        },
                        new
                        {
                            Id = "0fb2971c-915a-41f6-bc12-c252c117f104",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58c331df-296f-4d52-a792-15939068acf6",
                            Email = "anushie@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anushie",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moon",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANUSHIE@GMAIL.COM",
                            NormalizedUserName = "ANUSHIE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAnrdu+vVZ0jFAxQfF4SM8LE9uecpvjKSQ6/R/hd60hgdrlPUYkMI+RwbBnRWp731A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "04ff9958-1058-45a2-9ed3-855e9651d27f",
                            TwoFactorEnabled = false,
                            UserName = "anushie@gmail.com"
                        },
                        new
                        {
                            Id = "5bb079f1-260e-4342-bc18-edd9f95f956e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "802721cc-371f-436f-84b4-09e65cb98ebd",
                            Email = "mishka@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mishka",
                            IsProvincialAdmin = false,
                            IsTroopScouter = false,
                            LastName = "Moony",
                            LockoutEnabled = false,
                            NormalizedEmail = "MISHKA@GMAIL.COM",
                            NormalizedUserName = "MISHKA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJM2MtwrMmObFUdNRDqhwGVSpUDHDQmu37AxrT8EJYVkfMi7ragjMVHpP/c+eMfjXQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "ad649b43-b0b6-4250-be60-56d5bbbcf61c",
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

                    b.Property<string>("CampAttendance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
