using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PAupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cda6915-8ab6-442c-bfdf-c260d5428969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec87d164-8b13-4985-bc08-ac78b7f1a229");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20aa3a6f-61d6-4179-96da-cecf5e0e0250");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3100aeb1-2c09-4d9c-a170-53bcaf2dccac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "53d7ae16-1a9e-4eb6-bb10-fb54a7800c52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a6aaa0f-ce3d-4f41-8361-03fd8e19e012");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fcf4d087-d323-4658-89cc-aaef0cb1a039");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "494ef78e-4b15-427d-a522-0918ac262b4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5908f47-c779-42f0-af12-3a78cfd81c70", "AQAAAAEAACcQAAAAEBB/kjbBh4Fpg4LJI6kc8EVMNeCXZ+GJ1jpt/AnS3xzBdAeJb75RRdR7Tf9kFE7D9Q==", "3d58e5fc-f8f0-45fd-92bb-d64d4e931d06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "860f5bf9-4957-4b64-9e85-c0bcfdde66a0", "AQAAAAEAACcQAAAAEKmF3Di90kZ2te7xiXISBmbOLvdgFIrtuLX2hdVvsJa8OWzPd2DWmCaUE9/eaR17hA==", "7b18e1cc-43d2-4267-b707-aee139c52578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e10a68f-b3c3-42e6-ae2f-fbe33b96ca5f", "AQAAAAEAACcQAAAAECvxjQvNoWZnyqWA5ngiO6IpnlaQmi60M9Zy8STF6kzUqLy7hXwU+4Q2hZbehRtlhQ==", "3b02bfb4-732f-495a-ba90-3670bf95b9e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aa0dbd1-4e5b-40e0-8f80-c9ec29b8d17c", "AQAAAAEAACcQAAAAEDUg/SR4FR38veg6dGcrfWn9Q4FFNV0q652EslWsIo6E73DncrPG15iWbIAShrpUcA==", "bc33547d-5aab-43e6-9cb3-d4eced3bf542" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5bec561-5ef3-4752-8c78-163fae1384c0", "AQAAAAEAACcQAAAAEArGbH40Dy2ywyG/apC3i9VeuukqVOtL1NZz+rSOzb/WHT4iP4QDAoWpy7xJVhSE4g==", "ea9fbedc-47aa-48b8-829a-b6efa7379917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c766c85-f0e5-4c75-ab0a-dfec7db592cb", "AQAAAAEAACcQAAAAENgO8E/5kYMLyBPD0QhTHh3AVN9aeeWI9+zxSvM2r8tiru0KVORioK1Iht82zThyAA==", "e5ef4772-5ac2-4c6c-875b-c3eaaebe5ea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50b4960d-cafe-4c37-88e6-7579d93e383b", "AQAAAAEAACcQAAAAECahap8hoHhur9yCq/i2RNJ1SEu/UxRwAnabRklws3D0eITycwB7ScqASzCV2ueatg==", "7d979d99-9e5b-487f-8a07-46e7c06fd9ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a025689-6ed6-48e0-829d-cb7cf8ecf974", "AQAAAAEAACcQAAAAEKZjECkykzwiuOBWgzQQaS+Ic3bBN/7TOieQtKLABYSxBRhB4s7P/NtbQWWFDgv0XA==", "e5a29829-7e10-47f9-85a7-ee3c9f553f3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae65022-2a1f-4b96-aa72-85995cc81cb7", "AQAAAAEAACcQAAAAEOruyk1CwGfVZmrSHjcDayAOz8k0UicH8X/sWTgy8MP2JpT3C3atVLQ4nQvg8t8swA==", "6c7e2d96-c2e1-4310-a279-f91caa66c7a6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8cda6915-8ab6-442c-bfdf-c260d5428969", 0, null, null, "0e54b40b-2d31-4f23-a44c-1c1f3b7f1ac1", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELCLpcr4HS5NetFVT1Nm07/3+kSfYBAPrZ2t8IYzgM+sYwNi413FGxOP0mpzVPZe8g==", null, null, null, false, "1", "b1c73f5a-0a09-43e3-89c7-064e51f137d8", null, false, "mishka@gmail.com" },
                    { "ec87d164-8b13-4985-bc08-ac78b7f1a229", 0, null, null, "27cfd85b-15b9-4829-ab91-eea94ae36c91", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEIGJAODWB9OjuS3JB4rtIhY80QqDbHL2jdkwGwNRhD+LvLvOH/cEQhMaUoOhj4LyJg==", null, null, null, false, "1", "c63c3924-57bb-44cd-b09c-0321a647e4f9", null, false, "anushie@gmail.com" }
                });
        }
    }
}
