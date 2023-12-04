using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class HikeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00afb1f9-9aad-4fe8-8588-4d784a001b60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c6c25fe-f0af-4f51-a5d1-ffbbe2b261bb");

            migrationBuilder.CreateTable(
                name: "Hikes",
                columns: table => new
                {
                    HikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    HikeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VenueAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HikeCost = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    HikeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HikeAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hikes", x => x.HikeId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0df88ddb-4216-497a-a038-bd8effce6a1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "31da68bb-04a2-4f1a-98c8-1e22464a5bfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d059783f-751d-4448-8273-defe2fd5c831");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2ab60088-8182-44f8-a3be-e304b4b7ed00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d7af0db-19a8-45a1-8544-ac5646cbdba2", "AQAAAAEAACcQAAAAEMOigNKH5KHYqodaXTZd2S262DLzn5uAMSmf5ue5MLnByxF2l/vj6QEjwpOLDyKvmA==", "463fde16-0c4c-43e4-8b3c-437241080ddb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07606c21-79a1-4eba-9ee1-35beffb476b3", "AQAAAAEAACcQAAAAEJKfP/f6yRTWyUlc0Ik0JS/74JD7rUaHUJlBJD1i560sH1uprDmOjwdQoy1qkEdHAw==", "756f6eaa-ebc1-44b4-aedd-f6adaf4d3d43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "622364f1-4f66-44a9-b3f2-758476c61853", "AQAAAAEAACcQAAAAEIBOvgZuQR9WMAncuKcQkdYT6V+aT5dlEKHtG8MMpaDtp/1MR3UXLsq2dk2yC9tZyQ==", "194f5a67-f1a6-47e5-8b15-509ea6151488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb6beb5-a3d9-4e6f-a49e-d2ec28583586", "AQAAAAEAACcQAAAAEIeVr2jKjC3Y+0bdWMK0wgcV7Jyo5Dv3lPykp65vMqTXN3zPC0fA0WfYiua9uHtZOQ==", "644bfa56-28bc-4cff-8fd2-a88f6f08ab42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c63be12-e728-435d-981a-e1c4c9920511", "AQAAAAEAACcQAAAAENtvB2nPwQzy3dpLz+Y0Zo5jcthxGKqrvnUZEQ4tmnGRjbWfw3QpYiA2SHWQzp5abQ==", "27b35a35-b428-433e-af02-7d5a5da0096f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbba8e8d-7937-4798-957e-e2adc4e8e9e9", "AQAAAAEAACcQAAAAEEZzJPfkghc3oH2gNUyixQUCLR6FCOWCdOOxpGSO8iztUEBKkOdTVC6B/RY/S22SzQ==", "68f81bb3-8520-4b8f-bb05-dc23c7ceff00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4b4850-0391-428e-850a-d99c9f34b844", "AQAAAAEAACcQAAAAEF1Onep2MLiTy+ZkeMlbZn1OywDpU/cFYfhxGaVWjIpLPGR22tGhNUvaU3ynokSeBQ==", "bd2cbe30-1a4d-4400-abfd-94c815a94f2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1abf65a6-1adb-448c-ac7f-e78c710a8c3b", "AQAAAAEAACcQAAAAEBrp6IbploeCF/8cCdgtVsJhkohjRO5bZorW6ANyPParwdb1kYYtxjYr92QzN7+zhg==", "27ba355f-39fa-48ab-b30c-210beb818207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f4e45c5-08dc-4c33-820f-b7a441763281", "AQAAAAEAACcQAAAAEDueZ95QRzmAsj5J8hcnDmjiah7ku8KOJ0IA5yQH/2buWgUfmH1+OWGZ07sEW4TWow==", "44668cd4-c2ac-440b-8716-00f26b8e6149" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d607712-8535-4d49-bce1-c7da935f034c", 0, null, null, "1cd27630-b36d-4cae-9df2-705d8b5ecbf9", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGPTz2ZJ/RCsWU2vZlJb/+o4CzYP3c8Sd0a3ugvJNlHApYitRBch4vSnS1o9RJRP4A==", null, null, null, false, "1", "d41e2f8d-12b7-4462-ab74-1301e6072924", null, false, "anushie@gmail.com" },
                    { "c3ad931f-b617-4394-8685-1247ffb4cecc", 0, null, null, "ca4ebc3d-4047-416e-aba3-b8da6277dd0b", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEMDNZfPCdexYd/7obSywik2dIwoEszSPhbKdHQQVnB+qMPG98h2MINo9haZRyTa+rw==", null, null, null, false, "1", "2506724c-8be3-45ec-af14-835b7ad9ac06", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hikes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d607712-8535-4d49-bce1-c7da935f034c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3ad931f-b617-4394-8685-1247ffb4cecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cd45bd9b-e877-42a8-9f65-95c1197791ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b71d93a6-c76d-48a2-90e9-4b62f28ac897");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7a81950d-3026-428f-98cf-49f10fbb51cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3d4b9013-8a75-46e4-8687-5dda05d6917a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e7ed238-367d-4107-a1dc-95c298d9aeb5", "AQAAAAEAACcQAAAAEJ3t4BY4IpfrXEyThwQjXndD7YF9llNS7BVQPlohXQgJEj9UU0KZ9tazlVSIvM3MFA==", "5c84ef58-369c-4c5d-af65-65f85366843f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c556306e-57b2-4ddd-aa0e-9f40826ec98b", "AQAAAAEAACcQAAAAEPwYlhUthXX3FVhTzsfwI8hI4kpOoL/By4r4ZbVKczsO0DrSLxjB+tRf06Oho/XLvA==", "ad8ded78-a253-4a78-8ddf-72ff0d0c12e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "017be0b4-c25d-421c-842d-ff562baa5016", "AQAAAAEAACcQAAAAELPmbCTlbDXTfa/WcD45X6HKHK/Qy6siDN/4b7EmAD8q6HDS5Myde6fYOdiEGSPDmA==", "6936f468-ddee-4905-aba8-5784289f4b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d6e0bb4-fb7f-4270-9d2c-a4d58edd1e9d", "AQAAAAEAACcQAAAAEExQd9Yrq+4SOqaQz91B5DdIyuQkl5SIurSaTkj7UZvrqWIyWJkLUhbyszn4M0Dszw==", "fface108-3c2b-4276-ac4f-f6a105d0dfc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17c5941-29a9-4594-a7bb-05816b316e0e", "AQAAAAEAACcQAAAAEH0/t1mCiDIFfkUoBJjzODRDu8oQ1+vKA4oqaSCewo2Gh6385ME/oq4Gcj4ZUd23qw==", "a19afcdb-4df7-43e9-a642-6d05da4f4a49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17ade3ff-1368-4df4-8127-1791564bf6e4", "AQAAAAEAACcQAAAAEFMBS7Ybd31Fr0bi7g8AOL6g92YYSlAE0S09Nv1W4CL+pj7iHvBpxf9OSNz7E1EL9w==", "380653c9-ce3b-40d6-93ed-c76c376a25fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9ba4db7-0ed0-4bcc-a2b0-c9b5b10db248", "AQAAAAEAACcQAAAAEACQwjEDcWjkV0VTSGID7xXp9oQ314R4OeposD/108jFpWnluzPgPogNlgqF1Lc1Xw==", "a60b6a97-eacf-4244-b7a7-9f3602c661af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f350afd4-e308-4706-8bcc-b012585fdab9", "AQAAAAEAACcQAAAAEPGWDhCGqVgtFbaxq+y2BU4ofh8XDr8EAowDESvOwZoTi3ZqJhKlvph8m6I8txzfIA==", "646a2455-cb59-4bb5-bd1a-0abe57abc43a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "644772c3-8a12-422c-9a1c-49506a5db9d1", "AQAAAAEAACcQAAAAEKNViG9niraU+tNvfQo+fMDKR1HHq5u7Y4Df00SLwS1qjhA5dKHxNEoZtUmGFELsTg==", "d0ef033d-d8a5-4759-9c4c-6417d299bb0a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00afb1f9-9aad-4fe8-8588-4d784a001b60", 0, null, null, "5f218b70-3f06-48cd-868b-636dd0a32874", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHnnYeM3YQRnvz3+JHUr4ii4T+1AUxW+VqPPkPGyLQ9xt9eBQPgOf9SH9u1QnAO7Rg==", null, null, null, false, "1", "7030151d-d3af-427b-8c93-648a08d611f1", null, false, "anushie@gmail.com" },
                    { "0c6c25fe-f0af-4f51-a5d1-ffbbe2b261bb", 0, null, null, "58991920-5014-4df1-97e8-706ecd5c1ab0", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEMgkJ/HTxKzQ41bRt6H+9DYE/MATByls4WUclfjvr8bKIrnePCGNI6l0BEaJUkX0xQ==", null, null, null, false, "1", "59f7a273-37f8-45d7-820f-7aa810e86035", null, false, "mishka@gmail.com" }
                });
        }
    }
}
