using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CampMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42da64d4-c80f-4758-9a9b-3deb92f79801");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f6a82b-3746-4553-9eda-ea9bccb0dfe9");

            migrationBuilder.CreateTable(
                name: "Camps",
                columns: table => new
                {
                    CampId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    CampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VenueAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampCost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camps", x => x.CampId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d144c94-7a38-463b-b0d6-a538da9553dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "90757e69-26b3-423d-a71f-e79450231e8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ba8ca5eb-85ec-4f41-91e1-fe0697681013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7875a5db-93b8-4ec6-b86e-358d5af77b3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a02a8784-a472-4c4b-a1de-b031a1e8890d", "AQAAAAEAACcQAAAAEGVEoZ1iSwEe3zt70xzp/4n30jWY/heiM3w55n484cY8gwshiYppG8s1vnWhZsqqCw==", "984f9356-b4f9-4813-abaa-6cd559b1c944" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "117ea56e-f380-4dd5-9da8-f4a828a2d9ce", "AQAAAAEAACcQAAAAEAhwn4uDtI0Xh/RvHXu5BTjRcmajDS0T2cXvUxFQzANVjQEE2B4I3/qP9O0mFx1Oeg==", "4cb8620e-a9c0-4eed-92ce-6fa41940419e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40d45d8c-47ed-4abf-b24d-8a9ef9dfca19", "AQAAAAEAACcQAAAAEFtJ0cwz6Qzuw33/rg5cL+X2AU5L9sLgFuR/0JWtHEg6427yG2FJVz2CzWYiruDwWw==", "455ecb9f-0984-4b23-9c00-001564a75b74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99851355-de14-4925-9b34-9b2630e48b59", "AQAAAAEAACcQAAAAEKEtTrXk64uMH6ZyeZTNPmkA2C5ZFd6J5GCVZ4bBXLqqrL1nNJlupiBbvHk0Yw0p9g==", "0bf9c91d-5ebc-4847-a46f-c715be71ec99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67426cf9-8fd4-4b14-8b64-7a17b426db80", "AQAAAAEAACcQAAAAEGyxRiIAHxKNDZ1ZV3VfAPBOKmR+OOWqJ0iHgsuDcfegZ8f6nRrAq3bRc5hYmbk0Jg==", "82f35bfb-a970-4ed9-9e0e-469d85c21afc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea8a32a-e42c-4492-8b20-61fe12d99175", "AQAAAAEAACcQAAAAEFn2yi5rn/q6qqRkF0QkgN1kX0vEK7/UXNOsEl3GIhfghRRh3L2M4gOMbcZsojQ1rg==", "847bc06a-c7a4-4d96-99d3-747f6e08876a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7f7c0a-0455-4fd9-86d9-54dc9b111370", "AQAAAAEAACcQAAAAEGK/T0z8BS/MFrNksUk4iDZjZJ1FJMo4d4ROXOI0ADKWa5VbvVqjAVVs+41W+SNmVg==", "8ebeffe6-8bbb-4511-86ea-d6bdff96110b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae652689-2796-448b-925c-28e1c7797229", "AQAAAAEAACcQAAAAEKsOwTjl/b/2RpI+5/GvoTo8R8GvD35n7xzw/UMI+5vS92JIxWGFzIuKwpmeoriKWg==", "30ae87a7-ebfd-4aef-b535-1d12750474d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6856ca6c-54a2-43a8-98a3-bb57f9ef5bb5", "AQAAAAEAACcQAAAAENi88ILStjM/o7EdC8+RyLCsSjyFAM+KyEzWcK7mIEYRyQDPEgp1ZlpDn4EJKtij7w==", "da8c22ad-f557-4238-85eb-4804486ceac1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9761a887-71ad-4a7d-8972-ac86ffcb593d", 0, null, null, "8406a483-45da-4cef-8c4f-7992680e5a15", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAoB2fjpI61xh2kTzGkg2uz2HPR5RxG6yAJ5zPp9HflHczKWLz57K13QOqxXPy8mLw==", null, null, null, false, "1", "24eb2790-b1d0-4d79-af25-8d5f945a9872", null, false, "anushie@gmail.com" },
                    { "d13c066e-e78d-4e65-a171-19588b47e5e4", 0, null, null, "ba9ce782-87e5-4540-a3b0-3c3f56bea8cf", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHncg/BJyS33+vnoS30xtFlnYMk2sA2AAFduwa4YlLOiU5FSBQp1gRl3JzLsVJQYOg==", null, null, null, false, "1", "1478d36b-2470-44fc-a6fd-13a4c2beef5b", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camps");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9761a887-71ad-4a7d-8972-ac86ffcb593d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d13c066e-e78d-4e65-a171-19588b47e5e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "658325ac-ee18-4aec-9d4b-1485a07a2c54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8afb6336-12fb-4ebb-aa26-ce437a0e08bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1f1abd84-0132-4bfe-8217-daafe5f9c880");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7e6e6929-78df-41ed-8305-813f87f8749c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc9a333-1dff-4015-b21d-17c6ee9a4d90", "AQAAAAEAACcQAAAAEJnsPI1+Fz6WKvyi3yH/R6YmfGIpnpt3W5SLXKspJRoMwojUWZMnCrMm1po+SkQ5vQ==", "b43f7203-23a5-4a73-b638-e9aed7020990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91428f68-dab4-4f0d-826d-043502539a03", "AQAAAAEAACcQAAAAEJbOnRRfjekyeFN/EkNLTeBnnYAOCbg9WPtSqdCMvoFtZkJ5AisPkUjg5C2K8KB59A==", "06cbc2cc-8273-4c2a-9d2f-c6eff41dc3f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d88ebaa-2d9c-4d9f-862f-5bcf3f394c0b", "AQAAAAEAACcQAAAAECEB/E0+H/cuw6st3aruop6lY6emtuhKfw+jDVWBwmLqEue3aHkTrb5F86Q5i4UMvg==", "b27e3eb9-1f42-4b66-b39d-6e5632e4421a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c4ba42f-6500-4047-a78d-65eca3a3242e", "AQAAAAEAACcQAAAAEIXTxDAFZQjRHKfpzDYOWBRbDDSXVLPe2e0fn/RA7TmHaMBRlObMOZtAdVesm+wknQ==", "d7536073-e29f-4b00-af92-f2439423f614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc9f31f2-62c8-49a8-89fe-4db120ed48c6", "AQAAAAEAACcQAAAAEJyZV2g47n1Ka7FwW8vprMf/PTDT3UtkX/wYXz1HOhgDmkKvxyMj15lPyHyfik+cdA==", "3422af24-1994-48bf-ba50-44a22206fd1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98346cec-baf4-438a-abba-dd593a9f1cb2", "AQAAAAEAACcQAAAAELipCgsue05sk0swYBwgoxxoJF06dhO3675+tB8E+wgfZ6ygv7hv5oXbUxkeaXQzaw==", "98cd2142-4923-46d3-8ffe-223d2fe03469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34003cc8-a84b-41b0-a5a7-9a62edb1c8b2", "AQAAAAEAACcQAAAAEAyywrqoslse79431cAc+Ow52hHU8ex9OEerITt1h6Ol9EoBaxHr0WVAWSlZYcKoZA==", "801e2d0a-52c5-4157-864b-f2dd975dbd3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fefec7fb-2558-493c-88eb-5d977ec46e7d", "AQAAAAEAACcQAAAAEPJpx4lq0oGWC5dRLs1a36y9kGCS4zuRI87+lK5BCJ80XHqCpVx81e3+NQB8nhvLpQ==", "33d0d72a-d6ef-41d1-b2b1-708971ffe06d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3074413-4202-4338-8657-001e455edcbd", "AQAAAAEAACcQAAAAEDS/rdLy29Fdo/BpcG5C40HwD9m+SlK9dBlM/e/MJHL4zmuzM9eUlQkP+xMzP5eFZQ==", "150d6556-e73d-40bf-8354-043aed5ea755" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42da64d4-c80f-4758-9a9b-3deb92f79801", 0, null, null, "8d1d3062-666b-4da3-9263-2750ce529226", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAh5UNy6chAWR8ONG1V5sUyV4w54ep3RlxybqbQVh2hkV9HLcZVVTVwxJj9ZWza0TQ==", null, null, null, false, "1", "61758d6b-1084-4c5e-85d9-7a2d569ec0ae", null, false, "mishka@gmail.com" },
                    { "e8f6a82b-3746-4553-9eda-ea9bccb0dfe9", 0, null, null, "ca988e65-1af4-4320-95b2-edfb118d6eae", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJdASG0KG+IO5EAgxVp7uTvubi2YIv8B95Fhqi2EY7cWV/OvRxScncI2ZXjgXN0NMw==", null, null, null, false, "1", "bc3ca6c7-2c84-4aff-bdbf-de1a62f259ef", null, false, "anushie@gmail.com" }
                });
        }
    }
}
