using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class dataTypeAndSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8009b65f-b084-4888-9fc2-57baf28e5aeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df400462-49f3-4189-8df5-a2b2f81c2e97");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cda6915-8ab6-442c-bfdf-c260d5428969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec87d164-8b13-4985-bc08-ac78b7f1a229");

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
                value: "e860c216-e8be-4734-878a-8d2c28573f43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bfaa4220-2e81-4794-a677-a23f0d4ceb78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ea89d141-7609-4618-8a65-eef8f975b711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "b8c9eee3-9c6b-4ec4-867d-19b0885f6596");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0a5246-fe59-444c-a1d6-265eea84b129", "AQAAAAEAACcQAAAAEL5jPaQHY7+B8f/n0AdZRZIej/IYvWUJ6jNuKQs3tqqxCYDCYNMWv3DmXUr7vElXGw==", "55841eb1-3d04-43aa-8fb2-b2929d9d096f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02d9969-f564-4c92-8fbb-973062f82aa9", "AQAAAAEAACcQAAAAEKfwkQbYInQBYZL2J9tbwChNGAACoubWw9knAmEZaxfNuNY5fJ4N2H3ix7KcGB9Syg==", "494579cd-83f6-440b-85ca-b00fc7aea356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a2010f-4998-4ac1-83b9-a286d4fd8110", "AQAAAAEAACcQAAAAEFrbGxLK8+8iwub8IhqIqBYOlFczS92uvz5VRJA9ZUaTpS8BY8PNcfROyicXojLYAw==", "c7a42c14-7c49-408f-8ae2-1cc96c009dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68c6d742-637d-4f6f-8243-8047728bad81", "AQAAAAEAACcQAAAAEKL57eUAFOsvUuD7JH139/DVOrvZA6VoML6JjIAThtp4/w/lN3NsaDH9ubI8wshslg==", "4dfc7473-3070-45c5-be3d-cc8cbdcdc6aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731a8f7f-e630-4ae7-8059-877e581a67c6", "AQAAAAEAACcQAAAAEN5gAMLtbGJ7Rg3dSnR9Okp5bkQVMKvcB/EE64YXVtiavFV1P4sUBmxzHf2+QNKK1Q==", "d683da29-b66c-40e0-9d77-5a0bc72c3059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "137c3d8c-7fdc-47a1-92a8-0fe23d50adae", "AQAAAAEAACcQAAAAEDWTNT3JPCo8R5VQxdd30X1uZM89ihXxOJICoNIAOfusMmj/5LF4iEaEe9ZDtGBKuQ==", "2bb1b780-d3f5-422d-80b1-5119585b7a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c397d43b-ce1a-4c9a-9c7a-2b8ff9740027", "AQAAAAEAACcQAAAAEH7c3HQkuJA0WPGP7GIZJ4dhlBMSNE4d6LHlBejZmFb4e0dV6zye+jpVQ09MDDiaqw==", "a7d2800b-e49e-49a2-a672-e2200739f214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb268df1-a556-4408-9b95-83bf4a0db2dc", "AQAAAAEAACcQAAAAEILqkeLs0q1dDBDAx+0BrbMGs4ONqULOv53mfi5GFhLYXJA2JKMjKwCVH+nPyJdKaw==", "c99dcca0-a418-4ff2-b977-de2895786203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb043da2-ced1-493f-ac87-c7696dfeccb2", "AQAAAAEAACcQAAAAEO1Db8jm+SNkNngC48anTlq4Ecg9aGqqxiCUyhd1H9b5iNcvgDA3ObDr4ZN8biKD1A==", "678af0a0-6567-4445-bbee-f1724899f28e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8009b65f-b084-4888-9fc2-57baf28e5aeb", 0, null, null, "36ed0e9f-8011-46be-8a52-663aea5e0fb3", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEBDuZ0BOADdt3LitBhlclgPr2G6WQE1B7kEM1sbxfRUv/5XkYifLVyibt6kVQidChg==", null, null, null, false, "1", "f823b96c-58c2-421e-8f44-2450e4715234", null, false, "mishka@gmail.com" },
                    { "df400462-49f3-4189-8df5-a2b2f81c2e97", 0, null, null, "f56fbfb4-b073-4a69-a6ce-585e733fd647", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECsWwTihDxkqGA6IsxCsGqQN3Gw6t4zNSOGjDV2sQ2P6gGBZbMbGRzHNdvpkgCX+Kw==", null, null, null, false, "1", "7604f382-dff4-46c3-a6af-00d6b6a3d98f", null, false, "anushie@gmail.com" }
                });
        }
    }
}
