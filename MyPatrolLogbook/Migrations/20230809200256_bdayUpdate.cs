using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class bdayUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20aa3a6f-61d6-4179-96da-cecf5e0e0250");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3100aeb1-2c09-4d9c-a170-53bcaf2dccac");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42da64d4-c80f-4758-9a9b-3deb92f79801");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8f6a82b-3746-4553-9eda-ea9bccb0dfe9");

            migrationBuilder.AlterColumn<string>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9cc36d7a-e2f6-46fa-bb97-266b992cf02c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a4910d11-30a2-4e7f-b465-8a460b9cab49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4f1eb4a8-33c7-45e5-9e5c-93ed5d032105");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "be8f81fe-daea-496b-9cd5-ef7834b3b8d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b27a9b52-509c-411d-976d-61451f9cb42b", "AQAAAAEAACcQAAAAEKvs4X7cbxaT2wb/hgjKgt0LyA5bA2HVx3o7IVxPcLevUcbyXNZkG+mlCKs4eSfD4g==", "03921946-2fa5-43e0-a9d0-f2b25c1ae732" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467543e3-5df8-41e9-ab09-fbe762649c66", "AQAAAAEAACcQAAAAEMFWGui1I8GYAo0gA9G/rLvkJqPTKHqYNjln/4vsw16YltArZc9T/ZDJobX5+gGtCw==", "e8a72673-e240-40bf-8a7e-c0967ccfaa3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed974d97-2faa-4d38-88c3-42aaa168621a", "AQAAAAEAACcQAAAAEFNof9NrQhQG2h2jwZd095hnxh8nui3t1HHRI9sv2Oij0hQBfHqe8D8Cv0a+7IWVnQ==", "ca6a66a7-6638-4f2a-92a9-c898de7f435e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3af59a1c-7189-42e2-ae94-b385172d83e1", "AQAAAAEAACcQAAAAEJ4Nu2Zt8tLj6GKxoxU0fFVtfkbhDjLgbtNyQ2GNMAqX+f1ghWA0U/1sfQdxsM673Q==", "e21c028d-c916-4504-ab32-df2447e843cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0268c0c7-8a2d-4056-8f37-b60b2903add7", "AQAAAAEAACcQAAAAEHfs3wOi0mdXRWfOIofYMsc44b1nBluYuY5xnaxHs2a1Bha/sKC60y/321uaIpU8gQ==", "70b13835-8fc9-4935-85d1-57254800b660" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae201ad-1035-4589-b964-4678ae2a821e", "AQAAAAEAACcQAAAAEDLWTlkpj+YVyDEBNDFQftxR5xnnVsPcf14h5ZW0ocjjxjorHhc4gK86Kn8M0fMKNg==", "053deacf-4eb5-4d9d-a765-55cf7fc1b5fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f744e2a-4365-4b02-88be-e0b675e99878", "AQAAAAEAACcQAAAAEF5+UpmrrAE0NPWaLI5gZHReJ7NFN1DhFR/3CwmsFtbmvs2V9/FVfOCgNMQi43H8ZQ==", "dbfbb7cc-7588-4acc-ace7-7d0c76e02942" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb0cb6c4-e546-49a7-9a54-5b0ce4f5da0c", "AQAAAAEAACcQAAAAEJr7Xfyd+4R72HhB/YYL84PvP50fu8MveKd9OKyZE3dLHzYGiQsX+mtheIx4F0AT9A==", "0f002f20-c18c-4efc-884b-3a7825039cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfbf1e27-8f3a-4bc3-9802-2fca08417343", "AQAAAAEAACcQAAAAEBGDtawd+EtvZQV+ztz5kPkDi64byoRBj7vHyorWAhl/tIJMlYzFfBjH9Bqr9XIGmQ==", "27aa0fe7-815e-45f9-a586-c3e8bcd19c32" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20aa3a6f-61d6-4179-96da-cecf5e0e0250", 0, null, null, "72a81cd5-f66e-45db-bfc2-a1f6d1ddb5f5", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAb4bA92Vbh9MY7QGtj9IlmEntYD4tyHrsrITjYHRGovDMqweWM+Z5XXIsddhyYw4g==", null, null, null, false, "1", "5e6f4799-12a0-4733-9b69-7509f078b5c2", null, false, "anushie@gmail.com" },
                    { "3100aeb1-2c09-4d9c-a170-53bcaf2dccac", 0, null, null, "965b1a5d-d40d-4bc0-b5a9-127f66c91c36", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEDQ4QrPg0gha3gMkxubsNpxnq+17gpdlzGb2WiCwc76fzFyBV+wg9Ghj+4+aUOgkfQ==", null, null, null, false, "1", "05b8201c-5407-4131-938f-b210acf5d970", null, false, "mishka@gmail.com" }
                });
        }
    }
}
