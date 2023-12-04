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
    [Migration("20230809133910_BirthdayDateMigration")]
    partial class BirthdayDateMigration
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
                            ConcurrencyStamp = "723019b7-61e3-4a26-aa3b-56681037197a",
                            Name = "SuperUser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "f0b748a1-a58c-4748-97a2-e9eac966590d",
                            Name = "ProvincialAdmin",
                            NormalizedName = "PROVINCIALADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "45c9e6e4-d44e-49a1-8055-97c88e8a965a",
                            Name = "TroopScouter",
                            NormalizedName = "TROOPSCOUTER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "ca5840b6-b6c6-4689-be2f-ccb9422ecfa5",
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

                    b.Property<string>("CellNumber")
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "984055f2-330b-4f54-ae53-50cdad21a7cf",
                            Email = "mpl.admin.ec@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            IsProvincialAdmin = true,
                            LastName = "EC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA5DY+krACL76BiqX0q9wmLjA0z6lk7qVM5pL8r6jGiWZjzMqEmYWuCeZrHHiI6N8A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "5033828e-a610-4784-becb-0aa8594fb15a",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.ec@gmail.com"
                        },
                        new
                        {
                            Id = "b2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9fcf927c-a48b-4e94-90c5-2f3fd7aad08f",
                            Email = "mpl.admin.fs@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "FS",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGx6tGBkSL6u203cZBddq8efuRdXAeTXnyajMej6zIMmtMjVGdL+XlinOuFg+TavlA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "2",
                            SecurityStamp = "873075a6-51d4-456b-b1ef-7a44b315a37f",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.fs@gmail.com"
                        },
                        new
                        {
                            Id = "c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d5d5539-5067-4c6d-9cee-e7fb3f597584",
                            Email = "mpl.admin.gp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "GP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJS4vKtC9rE/3wWqMg02x9NnRQNaXMHwQbgANGQs89HAepNEtR04+ZnJbTBJmVKf0g==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "3",
                            SecurityStamp = "5af31fa9-ebe7-4698-9990-a72974c66c53",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.gp@gmail.com"
                        },
                        new
                        {
                            Id = "d4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba8d2cf8-71a4-4e1c-8b36-343cbc4e1a0a",
                            Email = "mpl.admin.kzn@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "KZN",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGCW4fsV5gkxNbqAxW+3Wdl12GZC2pybx/E4zH+aMB2X42SyyQz58I2zSb5h6RV5Yw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "4",
                            SecurityStamp = "3179bc0f-4307-4aea-a4b6-7600a2360755",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.kzn@gmail.com"
                        },
                        new
                        {
                            Id = "e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9059e1d-0394-4499-a02c-3d93d4341ba9",
                            Email = "mpl.admin.lp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "LP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENCS/UqiLi/vrA7Mu12bPOqwp8PLXHs7jO8Ku042NcknFaF48wKzmeXA1v4U77lZZQ==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "5",
                            SecurityStamp = "98e35b85-60cb-4fcf-921c-79f23f997269",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.lp@gmail.com"
                        },
                        new
                        {
                            Id = "f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "340aa058-90c0-44ef-a447-562612dd6445",
                            Email = "mpl.admin.mp@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "MP",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK9GVLZEBuN4cVyxcBNVqM8RJzA77kjNyogywm6MpbUIe6qdI4ZbXoRmy8Cbj1Aiyg==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "6",
                            SecurityStamp = "385d54d4-eca9-4160-bc0f-385f42616a61",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.mp@gmail.com"
                        },
                        new
                        {
                            Id = "g7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88e5cb2e-aab3-4433-b990-46027610375b",
                            Email = "mpl.admin.nc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELF1Xxn/haqPivnquFR/ILw9YvtGVgYBrEMg6HxmE/Eu5CmVstIdVZH8ORYVDLmp4A==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "7",
                            SecurityStamp = "92967c66-65fc-4f42-a11a-8ea7c3ae9aaf",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nc@gmail.com"
                        },
                        new
                        {
                            Id = "h8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e297565-8e11-40eb-9f5f-7e3d4ba2ac82",
                            Email = "mpl.admin.nw@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "NW",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDyOV+xi/DGZskzAKmE0UKlYTDgNsqRglV/zKt6vmaXiIMiIgmH4tL395VNeDpWh/g==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "8",
                            SecurityStamp = "18f97c3c-82e8-4a45-8960-f9f9b7a68f08",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.nw@gmail.com"
                        },
                        new
                        {
                            Id = "i9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6f95a55-0e0f-4d71-9a42-a45644811b2b",
                            Email = "mpl.admin.wc@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            IsProvincialAdmin = true,
                            LastName = "WC",
                            LockoutEnabled = false,
                            NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                            NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBpElpVB5t9MTGb232y9ljwOjBpaR7qBz0Qc3gKICrQhqY8ddYzLAPNdM6NqGvzt7w==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "9",
                            SecurityStamp = "b0c2a33c-6031-4384-9608-185518ae5b3f",
                            TwoFactorEnabled = false,
                            UserName = "mpl.admin.wc@gmail.com"
                        },
                        new
                        {
                            Id = "3e8bb124-a891-4c78-8342-6c7fb4c004d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "226db775-96e4-4382-a6e2-24afcae1074d",
                            Email = "anushie@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anushie",
                            LastName = "Moon",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANUSHIE@GMAIL.COM",
                            NormalizedUserName = "ANUSHIE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDvuHzu5esYRycCBTMEhCKTAltEe4/KTkrWCahwMHJ51DtZ/Wzn32EEw9xVK8ihwNw==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "8e055b14-28c4-4978-8756-49aee1d8c6a7",
                            TwoFactorEnabled = false,
                            UserName = "anushie@gmail.com"
                        },
                        new
                        {
                            Id = "1e229809-7311-447e-a2ee-a5b18c5fb12a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "38f7954e-8249-4b0f-a21f-6730336f0fd2",
                            Email = "mishka@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mishka",
                            LastName = "Moony",
                            LockoutEnabled = false,
                            NormalizedEmail = "MISHKA@GMAIL.COM",
                            NormalizedUserName = "MISHKA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIrFjCl+5sfHiZHi9fvCfMHnO5lg26FyVrJhJg63uL8GuxDpcdbTzfKiaUQKuEBpHA==",
                            PhoneNumberConfirmed = false,
                            ProvinceId = "1",
                            SecurityStamp = "f726285e-efc1-4a92-89d3-b3b81fa808fc",
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