using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolActivityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af5f38ec-ac2e-407f-bf98-d8a3705438a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce39ab57-4a1e-4033-8620-401d220a3339");

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    PatrolActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.PatrolActivityId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b5dae8e-e519-4bb0-9290-c54bdcdef3c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ac819f8-d693-4703-a2cf-a5f1b80b7c4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7d434167-86d1-4ca0-9450-a392fbfd5136");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9593c3d7-0f57-4163-9439-0eea4d0556b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fc13ec67-2e23-4785-8b89-32b6870dbf82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "df4c017e-03ae-4129-845f-a6ed55f3e083");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0a3f9f-baca-41cf-a9a5-0a0b8327ac9b", "AQAAAAEAACcQAAAAEDCP+2bp2AJAcliSvxLCrqFbM2x03w2ZWo58CoRgmXYNECnPXBcdOw47l//leBfsxg==", "c3bb2595-a095-42e5-ad9c-6326b7209487" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7af5e779-cc01-4236-934d-1eec0fafe879", "AQAAAAEAACcQAAAAEKHRMsEJDOlQGs2O5nT44yPddnTzQV3rIYkuqnhFG+c+Yf3f9OOg3P46xjA/KtdNGg==", "8534f5ce-d4ec-4da5-82db-bda581397dca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6da18568-5c63-4519-b61f-1cc0f299eb00", "AQAAAAEAACcQAAAAEFX8VyOv0J5Kcc7FZnfmIqL7MC1mjBnABXQYV3V0hsg6S4r3Cc5cpJwRLqvpGgy0vw==", "80092f53-3454-4dab-aa70-69197e21cbae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c57d9c04-cb1e-4e4e-a2bd-1bee0b23b48f", "AQAAAAEAACcQAAAAEG7egoxBEGVrm0Pyqu1aeZVKlRQ/I/dh07Qh97jnoTL5p2+dIWI0vz8HVshU5IZKsg==", "372734d3-baaf-4812-802f-a16b43c9c44b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42495540-5743-40fa-819d-786ee9ea979c", "AQAAAAEAACcQAAAAENWLJKRryhaFrDvzDxi+mZg3zuTlUMpb5maWJI+UN1DCJXANBWA34Yff6sZFEbfX1g==", "f7026b93-8cc1-448e-9e07-ade8389ce98b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe610c43-6b69-462a-8eb8-5291a1e26f8b", "AQAAAAEAACcQAAAAEE12ykBKZ1nMUJxc5X8J1f6SxmOAXzZXd2kCf2UJW3zQIpcXPNUhJ7PmJoeU2Ht9HQ==", "74400b03-42fd-41b9-a4b2-a5bc2cfd688f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe306f9-ae02-4e82-b86f-fe09efd0d4f6", "AQAAAAEAACcQAAAAEOIhBGV/QmK2hoS9Ht+u0zCkk56WsK6zZBGOF/dt5143dTmCaSi0IsNCL/HmAqyJLg==", "b9920c6c-1473-4b05-9282-445058554edd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11ad7f34-2ae9-4ceb-85c7-fddedafa4e53", "AQAAAAEAACcQAAAAEDrx9dSlcSmZxPIaz2tDseU1FJyVyiUMCN7sfRmvgMmYAZ9aj+fdF78zvyVMkwhqwA==", "c9f3ade3-f8b3-4670-8f0f-cb5a1222606b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed9cbfd3-b6fb-43be-b106-6c24b79bce28", "AQAAAAEAACcQAAAAEA+eHGi68m7FGXSs+p76mlRqxcPkYRudxaS+8LmLMqN3ZYnng3sjCms5YMdDt+e5MA==", "74cc1995-9dfc-465b-b22d-0d9dbaffde48" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af5f38ec-ac2e-407f-bf98-d8a3705438a9", 0, null, null, "d2048783-b422-49e6-86c8-e1e4a417e16f", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJ74qpKQFZ40x5+OWUztmrDGv59J1Hh5OHPepfPCE+sm6jK9DlJ+yCmY9m4sbr0gPg==", null, null, null, false, "1", "6f5abd64-caac-46c2-95ed-1ef812de470c", null, false, "mishka@gmail.com" },
                    { "ce39ab57-4a1e-4033-8620-401d220a3339", 0, null, null, "9d472d14-f27b-486f-83cb-c5e5229f3afe", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEN2/U9AbnIF15s3ClKe1wSb0eJNN0y81kxJyFL/V8cA8iSeGUspI4qQkDK+/P5q5jA==", null, null, null, false, "1", "493e392e-8d5a-4b0b-aa5b-efe68f9587fa", null, false, "anushie@gmail.com" }
                });
        }
    }
}
