using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CommunityServiceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d607712-8535-4d49-bce1-c7da935f034c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3ad931f-b617-4394-8685-1247ffb4cecc");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    CommunityServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrolId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectHours = table.Column<int>(type: "int", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectAttendance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.CommunityServiceId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af5f38ec-ac2e-407f-bf98-d8a3705438a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce39ab57-4a1e-4033-8620-401d220a3339");

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
    }
}
