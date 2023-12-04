using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolInCouncilMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f058e88-7383-4ff5-b234-35e918c2cdb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb5104e-7dbd-4462-9463-e3c9078fa173");

            migrationBuilder.CreateTable(
                name: "PatrolInCouncils",
                columns: table => new
                {
                    PatrolInCouncilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    PICDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PICAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PICPoints = table.Column<int>(type: "int", nullable: false),
                    PICDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatrolInCouncils", x => x.PatrolInCouncilId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "41cb6f75-58eb-489f-9f11-ec4cb605a9a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "700a6abb-6eff-44eb-bcbd-4676bbb074b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "43ee071b-4a26-4d95-8d04-9d88c9c912ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "da0009dd-d7fb-48f1-883a-119bfa3d4073");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a76d40-9860-4ce0-9746-2c544619bba1", "AQAAAAEAACcQAAAAEI8EGRXfmqK2NI+YhfkcDtpXi1RlIJYrKRns2/sCQ7iPlDeQH3X/Fa6MPYcmGUMRcg==", "ef3a0569-a63a-4e5c-8392-93d032fa8d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799b9e1f-40f8-4a3d-81f1-df330eee8cbc", "AQAAAAEAACcQAAAAENziAtgRTuKofbX+q88GdPI+pp17kb3+Yl4gND92pfZJbkERdxEpYeDS5ze5/ltj+w==", "5788da4f-c41c-4479-a027-d33302cae5ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93655136-6b96-4903-8b7e-908fb182749d", "AQAAAAEAACcQAAAAEJOMPrveStf6GMqi9fa0shG+635NXE1nDqJ05kHKbo951o5zNcv0PM7lDy4n4J1waA==", "9929dc61-589a-414f-8efc-489e38026a5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d000e99b-5ef7-4a68-a0bd-50a8219a087b", "AQAAAAEAACcQAAAAEOelbXvDtaSggy1Fp6Y1f04nGaY8SoDyEYUwIe1K7KuxgJUwK044ot9rJDd1oI4hOA==", "34667397-76a2-4986-88ea-6d9a444f463f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6737279d-a9ad-45bd-9a57-682f20339f35", "AQAAAAEAACcQAAAAED9jsdEAtQfWEEIJZgv18443FBkwSQ63e72Vx2B+1vK17dix0gcXk05R7Nuqtx1sCA==", "fef73be5-557c-44aa-b7e5-8614a0684814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80c0fcf9-581b-4f19-994a-5f230ae4fa47", "AQAAAAEAACcQAAAAEH/ojWdax5Lt9S6Sq+GWHJHbZtcl24yqRNSVDnpautYJfo6XAvgcYEtmZCj+bJ7IDw==", "3bfedf59-050e-4343-8c57-6c36685af48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19700889-2ada-4479-988e-6e573e0fe2a5", "AQAAAAEAACcQAAAAEBhfDQLV8fqxztFHb6YZPNibgxU3LGcsGmtQYVmKi0iI/P93pW6B/HjMkrBgTP3phA==", "074498d8-7a0b-4705-8cd0-bb235719f231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47811c9-e1fd-4ab0-8e42-59be0138a941", "AQAAAAEAACcQAAAAEBdyyV7rreuo8881nf5Itscf+/oeA02ZkO5u5qFxtXH2WiEovlsGIGRcNRHV8qKotw==", "2d3c8fd9-ac91-48f1-a70b-dee524fdd0af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5126404-d648-4408-803d-0dbd1551028a", "AQAAAAEAACcQAAAAEJM76r0kxEot6ca/mB0gjxGX6PXX8NKzXqC6an6JLv7aXoWaLcIljcr59Yp3U9fYJg==", "276ea142-2ea4-4bed-8c6a-fb8aab623b59" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b62f2ca-52b7-41c6-9314-db1466a0a24e", 0, null, null, "7756915c-2bf1-4b2e-9fc8-1ae9832b95e6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEBAH/v1cRYJ+coQ02gTLeViBqYOCSNDHKvxHJcJkZRrUGHLTKRwsLgTQM5yNqrIx1A==", null, null, null, false, "1", "a384c736-6ee7-49d5-bd5c-60063cbbbd4d", null, false, "mishka@gmail.com" },
                    { "c51d7405-1dc0-443e-8260-a1eef425f319", 0, null, null, "bf7b90fc-4f66-4a4a-85bb-3c2a04063245", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECaKIURnCr0InoQoCkND/O8FfoNgpjI0AJuwi+mda+ProZCyPlpsyZWELCVRTXtw9Q==", null, null, null, false, "1", "4589566e-a387-426a-b726-412d391bf474", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatrolInCouncils");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62f2ca-52b7-41c6-9314-db1466a0a24e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c51d7405-1dc0-443e-8260-a1eef425f319");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "120ee0b9-bae1-4585-a1d9-12432778ae32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3d5b9caf-7c02-4029-944f-3e0eb7f3f246");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "12e47330-e5f8-4791-8d92-24fcdf9e8570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "046bbe97-0f82-49a1-ba98-864215401cf5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "594f852c-6137-44ce-a49a-6533e25cec5c", "AQAAAAEAACcQAAAAEDnAD5i6qnREWCN1wXZxm7GSGV01hJaomH6FAe+3S/L0jcJQQJuBQa0G6A23hVnZ+g==", "5c0b1390-5fd2-43c9-9db5-8ffaf5168ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0821b2c9-377f-44fc-863c-0c40069edfb4", "AQAAAAEAACcQAAAAEDb8rvAg++ZdsF5aV4hWmklbQhX2wmsBQVqKlRWOu7bYKZaKs7JF14uPoe8usnX/Qg==", "28109ab0-cfcf-4b66-bb87-c23d620bcfac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e081fed9-54cf-4ee8-a355-23f04740ebb1", "AQAAAAEAACcQAAAAEMouDhG4qpFe1/5TFCzfxldWcyTyA0WI8U+o7Cjz6XlP8ZuppxliyKk4wLvCdxd3oA==", "a56b2747-5ad0-4bb0-8f5c-0be1d428a6bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "526ec3de-24a4-440d-aab5-ddf60587a9db", "AQAAAAEAACcQAAAAEEWqLHJ5nNnK9PwfyV4+wnVM+kut35UE2eNDCnK7yxUgC1oP+bPihB1O5poozTYdkw==", "a1b0955c-aa3a-4f9a-b379-f4d2a5508237" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c48f300-71ff-41ae-923f-140190e88d8d", "AQAAAAEAACcQAAAAEPbPZBYrd4MqxkqqUOI/e9vtxxdBYdSUxlWovoKbsWbJpH2l898bLTIjyzb3HD3QIg==", "7a111ff6-8f5c-4e17-a139-f35ad1bc870c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "784a3072-ed00-43ea-9efa-630ae50bc8f6", "AQAAAAEAACcQAAAAEDyHarCoJ8nBeOxqKga7sWc6od647EoHPrv/VbEWkGglBQZ5BK+x8uesBXxWj+c04w==", "27db93af-ea40-464a-b697-fa46533d9ce3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "785db541-0d0d-4706-a215-bc2a4908b62a", "AQAAAAEAACcQAAAAEI5/LXra84UHjn8zKOxnyN13ko37VujstIGsPeJEskl2674wPOS1KJdRgXvjiCfaDg==", "b40e9ca2-8b50-45ec-8ff5-b6609d29e8d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ab556c2-624d-4050-b6fc-a11063e8a11e", "AQAAAAEAACcQAAAAEPETyBCOe9FJw1VarVisMbjssaZDVcI+3ICOx80Th38XYHWnEOItATO+OawZwDDTiA==", "59093b13-35ae-499e-997e-97e7772b0df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b7a67b-fee9-4dbf-8f15-3b2e55dca46a", "AQAAAAEAACcQAAAAEPHiJIAySyd7FbxIo5SKLkAXdbcRddxiDKWwbnV9v0950E+5aWqDFi4IUjIrC3d8Hw==", "70837242-d1e6-46d5-99fd-c4e9e61f2cfa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7f058e88-7383-4ff5-b234-35e918c2cdb1", 0, null, null, "95e12684-36fa-4463-ba70-2fe38d64468a", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELTqKi9mB24vaoYkoqiIHuVYE5Zo2tmyqxhn4V9wanWfW37829dS+jLzBjsPEFQrfg==", null, null, null, false, "1", "2731c2af-cb1b-467f-8c72-4c431fe5d3b3", null, false, "anushie@gmail.com" },
                    { "9bb5104e-7dbd-4462-9463-e3c9078fa173", 0, null, null, "afd8aa5a-3c27-4d2f-9182-bc3058c184ff", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGTw4eN/4RksKt4KY9aNa7TJmDIqly9Lx5lFT1fzBU5EwpTkx5yCP9VZepfELGOF5A==", null, null, null, false, "1", "6db050b1-d5a3-4553-8d26-3e0b4069f4c6", null, false, "mishka@gmail.com" }
                });
        }
    }
}
