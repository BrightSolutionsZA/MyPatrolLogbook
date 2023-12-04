using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fc0c851-b320-4848-b76f-c865d7471010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79405132-38c7-4ef2-8de9-a431d1efbd3c");

            migrationBuilder.AddColumn<string>(
                name: "CampAttendance",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00afb1f9-9aad-4fe8-8588-4d784a001b60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c6c25fe-f0af-4f51-a5d1-ffbbe2b261bb");

            migrationBuilder.DropColumn(
                name: "CampAttendance",
                table: "Camps");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "49b3b6b9-03f1-4b33-9313-bf4d393f2ba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "83dc6290-396c-4942-ba99-8ddfe2b189dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "69e17cfd-4320-4ace-b640-b67199cb28d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "021f0768-5541-4bb2-a736-1f3afc8a02b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2030a2e-b626-4da0-bf50-ae29c520d750", "AQAAAAEAACcQAAAAEIls3xKhbmjOsRUM28gP12qFo2yk5EBspuCQZWkQLk+7D2LboSEiJ3TlKDWPjYCgig==", "bb9d1c6c-712b-41cf-90a0-87111f649d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9921f9-180f-4c74-b764-889d1c413ebd", "AQAAAAEAACcQAAAAEFqZhaV8nWgd/bTODu8MzlvVyP2sEOOpIv0gLWXTjpwd6nIxJWKUWbfTwSAro8aeqA==", "e8522256-9aff-4de4-98e2-b9ebe449956b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d70b3c2e-dbc0-4e10-a700-7bebacb3cafb", "AQAAAAEAACcQAAAAEHuVL3dHxNA0lyjD6DFHG9LmOROnUdlblVgvbSuRj3YGJNtGfjgaCVikb4C58gYUfA==", "0760c183-e3e1-4132-9ce7-b39d65bf3391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa852af8-e7ff-41c4-a93b-d3649c64f47b", "AQAAAAEAACcQAAAAECkqJh6ztuN0429k7qVbCMFsCeJj4g05MGqjfOknqByDZ71FvBwdE6KnAslhGzyltg==", "bef80af7-f881-4c6f-bb7a-a9aa2b16b6bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf12afb6-876e-4ef2-b3b4-f4fae17144c4", "AQAAAAEAACcQAAAAEACMezHl2/CjErMfE5q42RNzH04M7/a7OeWkjukKh1knkVWq07dUqedY2wcKsnK1ig==", "bfa99f98-2cd8-4f0c-9741-34beaf4cf421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db480083-b757-4ad1-a949-295795467217", "AQAAAAEAACcQAAAAEGFkTLpFT70jw03sSj9/IjqBspd4dURN6/ndRZY1aBKzoLhgPOftB1FRB+dIgv+H9w==", "92b95f66-91a1-46fa-8a3c-ff4e28aab8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94843f7-2279-4f90-b835-6ad9379ff3a9", "AQAAAAEAACcQAAAAEB3E6w1veCnBLrgf7zh0oh9zq/7cz6UjC8hMyuxxWA7wI3Iuomz2SpxoIpRz0oaIAw==", "9c662d8e-9b32-468d-9d28-c7287c695c87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2df74576-acd2-4d29-9cca-3e8aa06634b8", "AQAAAAEAACcQAAAAECUJy1CZUq33/mWs+z9+tBUwupc0QQdu0ESYsTMmhSIYB8gPLYsLYLumjMhcV0HqYg==", "868e106e-e335-4b71-8efc-347075f8dfcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c69f5595-8924-4256-9242-7a5cd7684d66", "AQAAAAEAACcQAAAAEMqWfPPw0jcdpTfWj34iLSogOFFhAwc7Yz6MmS4rGx/jU2fBS7Ed+lt6H38zrz0QXg==", "184b85a8-c33c-4282-ae3c-36aaabd01f75" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5fc0c851-b320-4848-b76f-c865d7471010", 0, null, null, "52c16190-7634-4c2e-acd2-838fa37989b6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELlBwTrOnP4P65OQ+fUNKAtfjN4Jiw7FkNq74l7+lbcQQ3AZIDZF2l/oPN4GCSOVUQ==", null, null, null, false, "1", "6d3f2986-6127-423b-a85e-b2f9ddff5501", null, false, "mishka@gmail.com" },
                    { "79405132-38c7-4ef2-8de9-a431d1efbd3c", 0, null, null, "72b1c037-2cd7-449c-bdbd-4a8dd20ea8f9", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEF+wu5xD7/y7DfJb+6d8Vo0y3ksrMJQnq2sJrng0VzVFVTUVua4KrzfP5LtawylObA==", null, null, null, false, "1", "e3e26998-2243-4ed9-b993-de03905ed086", null, false, "anushie@gmail.com" }
                });
        }
    }
}
