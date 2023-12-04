using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class RegisterMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b5dae8e-e519-4bb0-9290-c54bdcdef3c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac819f8-d693-4703-a2cf-a5f1b80b7c4b");

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.RegisterId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f058e88-7383-4ff5-b234-35e918c2cdb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb5104e-7dbd-4462-9463-e3c9078fa173");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0791e3fe-a9d0-4510-9fc0-76dc1178e879");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0280bae0-0937-4663-938f-6c4af45b8318");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9d25c4b9-a530-4a8a-ab25-87398b839070");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f78bfdc7-750b-4c0a-b25b-e3411166a848");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d30a743-df6a-4c8c-adc8-d4cb90b9be99", "AQAAAAEAACcQAAAAEGqkGGErfYPk4TbhrdcQbz7qFdQvmDAFCp7tTL8z0f7jVmGwIz3yrzWDAnLo79qfoA==", "740ae7c8-f844-42c1-a785-26692c45779f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67d26b70-7c6c-4957-8aa3-7246e32a2657", "AQAAAAEAACcQAAAAEFHVL573ClfXXQQAjL3Ulj+N7Aj2U2NtSQV/hRNPzEW7xjjVaFhCiSGIv9jzZObhSQ==", "9755d861-4df2-4376-9b79-43ce9b11798d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66dbc4c9-431d-431d-a895-d7184af64a71", "AQAAAAEAACcQAAAAEBebC8ogvLbw/NUDm0eGY+PvndyhovCIE5z1wktPSqGr2A4qUSd1s+/HYO0kdh6dyA==", "5a2e8d28-781c-4437-8b0c-6f123d3688a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd03578b-38fd-4da6-a0ac-76c62e4db10c", "AQAAAAEAACcQAAAAENnI/30cg19wYBhoyIhfjKxiB94sGCgGUikx5IdY1sknKgL3dIyuTRQS2LK3mJUY9w==", "84efbf6e-a304-40e3-9e46-d8cb5981e666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7275a9d-666a-4c60-8d6a-c38dcdc57f0e", "AQAAAAEAACcQAAAAED/pRkLB9/92TLc3a0+AxqzGI0TaLuw85ibqaTPEdVCFA0uD5r57Iowdg2h1bM8EAQ==", "9134dcf0-64ce-41f2-8a7a-aa8eecb04802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7d0429e-e34c-4e7c-a333-8fc31a7c946e", "AQAAAAEAACcQAAAAEHeDJUZDIJRvflwBufJ/yaYXK6rFtyIBQJqx4a9vmxYGbfP55yZhwlEJ9CrLWxl5pw==", "34a0dce9-f756-43bf-be54-6cf85068dac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49a5ead2-0317-401e-8fdf-c041ce5aec2e", "AQAAAAEAACcQAAAAEAgtJ/81s3QR6IxCVZ9FrCj0CVjX16nt4eGfO1QN/DyjvZuHhrcOwRT8+ogrUv2pLg==", "6940d0e8-f294-423d-9a0a-e64608f9e357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5abf1c-49a2-4333-a788-88989c0c88c5", "AQAAAAEAACcQAAAAEMlXkQANXmstDmWpe9ZM5K+2MswCMA+/C8pVftbMF65VwOqa6gzJT8Yiu3zxz3Yhow==", "5543da5c-617e-4716-b0b9-8f4a2566ac15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "644bc0b8-fb12-4098-96b6-0afab29a777a", "AQAAAAEAACcQAAAAEBCvZA6B0EiLcfTd5T3NfZHXLQmvE9WPvW4mgNpugKSoaZ4pRAYW0POf55Oh4QtVDA==", "5b7947dd-7e70-426e-ae85-6ed9e98999b3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b5dae8e-e519-4bb0-9290-c54bdcdef3c5", 0, null, null, "1b576afc-2452-4a2c-ade4-a96e12dcf07d", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGoF4+3nW8fse7TZ7oi67OzsziifgUjsAASR22KbyYMIucp1VOjNqTH/r6pWRnV0rQ==", null, null, null, false, "1", "6914b5d6-1799-4256-81a2-ab60428711e2", null, false, "mishka@gmail.com" },
                    { "7ac819f8-d693-4703-a2cf-a5f1b80b7c4b", 0, null, null, "9d137326-95d7-4a61-a73c-497f575822e2", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEPgSBa4EES2Yn2g6P5UiTjeYXGd9ljuBkDSfyYmxkB6tEiXNbdnLvsHDutEoJJ7nCQ==", null, null, null, false, "1", "e71eb50c-a2c8-4141-873e-f7c98a63c88d", null, false, "anushie@gmail.com" }
                });
        }
    }
}
