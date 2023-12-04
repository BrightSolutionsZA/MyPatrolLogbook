using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyPatrolLogbook.Models
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        // Create the various tables
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Troop> Troops { get; set; }
        public DbSet<Patrol> Patrols { get; set; }
        public DbSet<Camp> Camps { get; set; }
        public DbSet<Hike> Hikes { get; set; }
        public DbSet<CommunityService> Projects { get; set; }
		public DbSet<PatrolActivity> Activities { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<PatrolInCouncil> PatrolInCouncils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(100);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.LastName)
                .HasMaxLength(150);

			var hasher = new PasswordHasher<ApplicationUser>();

			//Seeding the User to AspNetUsers table
			modelBuilder.Entity<ApplicationUser>().HasData(
				new ApplicationUser
				{
					Id = "a1",
					UserName = "mpl.admin.ec@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.EC@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Test",
					LastName = "EC",
					Email = "mpl.admin.ec@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.EC@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminEC!1"),
					ProvinceId = "1",
					IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "b2",
					UserName = "mpl.admin.fs@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.FS@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "FS",
					Email = "mpl.admin.fs@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.FS@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminFS!2"),
					ProvinceId = "2",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "c3",
					UserName = "mpl.admin.gp@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.GP@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "GP",
					Email = "mpl.admin.gp@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.GP@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminGP!3"),
					ProvinceId = "3",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "d4",
					UserName = "mpl.admin.kzn@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.KZN@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "KZN",
					Email = "mpl.admin.kzn@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.KZN@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminKZN!4"),
					ProvinceId = "4",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "e5",
					UserName = "mpl.admin.lp@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.LP@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "LP",
					Email = "mpl.admin.lp@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.LP@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminLP!5"),
					ProvinceId = "5",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "f6",
					UserName = "mpl.admin.mp@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.MP@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "MP",
					Email = "mpl.admin.mp@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.MP@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminMP!6"),
					ProvinceId = "6",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "g7",
					UserName = "mpl.admin.nc@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.NC@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "NC",
					Email = "mpl.admin.nc@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.NC@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminNC!7"),
					ProvinceId = "7",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "h8",
					UserName = "mpl.admin.nw@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.NW@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "NW",
					Email = "mpl.admin.nw@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.NW@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminNW!8"),
					ProvinceId = "8",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "i9",
					UserName = "mpl.admin.wc@gmail.com",
                    NormalizedUserName = "MPL.ADMIN.WC@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "Admin",
					LastName = "WC",
					Email = "mpl.admin.wc@gmail.com",
                    NormalizedEmail = "MPL.ADMIN.WC@GMAIL.COM",
                    EmailConfirmed = true,
					PasswordHash = hasher.HashPassword(null, "AdminWC!9"),
					ProvinceId = "9",
                    IsProvincialAdmin = true
                }, new ApplicationUser
				{
					Id = "j10",
					UserName = "mpl.superuser@gmail.com",
                    NormalizedUserName = "MPL.SUPERUSER@GMAIL.COM",
                    SSAID = "0",
                    FirstName = "SuperUser",
                    LastName = "Admin",
                    Email = "mpl.superuser@gmail.com",
					NormalizedEmail = "MPL.SUPERUSER@GMAIL.COM",
					EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Super!2"),
                    ProvinceId = "4",
                    IsTroopScouter = false,
                    IsProvincialAdmin = false
                }
                );

			//Seeding the roles to AspNetRoles Table
			modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "SuperUser", NormalizedName = "SUPERUSER".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "ProvincialAdmin", NormalizedName = "PROVINCIALADMIN".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3", Name = "TroopScouter", NormalizedName = "TROOPSCOUTER".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "4", Name = "Scout", NormalizedName = "SCOUT".ToUpper() });

			//Seeding the relation between our user and role to AspNetUserRoles table
			modelBuilder.Entity<IdentityUserRole<string>>().HasData(
				new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "a1"
				},
				new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "b2"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "c3"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "d4"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "e5"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "f6"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "g7"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "h8"
				}, new IdentityUserRole<string>
				{
					RoleId = "2",
					UserId = "i9"
				}, new IdentityUserRole<string>
				{
					RoleId = "1",
					UserId = "j10"
				}
			);
			// Seeding provinces to the Province Table
			modelBuilder.Entity<Province>().HasData(
                new Province { ProvinceId = 1, ProvinceName = "Eastern Cape" },
                new Province { ProvinceId = 2, ProvinceName = "Free State" },
                new Province { ProvinceId = 3, ProvinceName = "Gauteng" },
                new Province { ProvinceId = 4, ProvinceName = "KwaZulu-Natal" },
                new Province { ProvinceId = 5, ProvinceName = "Limpopo" },
                new Province { ProvinceId = 6, ProvinceName = "Mpumalanga" },
                new Province { ProvinceId = 7, ProvinceName = "Northern Cape" },
                new Province { ProvinceId = 8, ProvinceName = "North West" },
                new Province { ProvinceId = 9, ProvinceName = "Western Cape" }
            );

            // Seeding troops to the Troop Table
            modelBuilder.Entity<Troop>().HasData(
                new Troop { TroopId = 1, ProvinceId = 4, TroopName = "57th Trafalgar Sea Scout Group" },
                new Troop { TroopId = 2, ProvinceId = 9, TroopName = "2nd Rondebosch Scout Group" },
                new Troop { TroopId = 3, ProvinceId = 8, TroopName = "1st Ikageng Scout Group" },
                new Troop { TroopId = 4, ProvinceId = 7, TroopName = "1st Isago Scout Group" },
                new Troop { TroopId = 5, ProvinceId = 6, TroopName = "1st Nelspruit Scout Group" },
                new Troop { TroopId = 6, ProvinceId = 5, TroopName = "1st Polokwane Scout Group" },
                new Troop { TroopId = 7, ProvinceId = 4, TroopName = "4th Durban Scout Group" },
                new Troop { TroopId = 8, ProvinceId = 3, TroopName = "1st Bryanston Scout Group" },
                new Troop { TroopId = 9, ProvinceId = 2, TroopName = "1st Qwaqwa Scout Group" },
                new Troop { TroopId = 10, ProvinceId = 1, TroopName = "1st Vincent Scout Group" }
            );

        }
    }
}
