using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class HikeDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ea0a81f-af62-48bf-b24d-9eeebe96e657");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7630c52d-5b28-448d-ae4b-b22df361e3fc");

            migrationBuilder.AddColumn<string>(
                name: "EndDateTimeStr",
                table: "Hikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDateTimeStr",
                table: "Hikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d9a357a0-685d-41c2-a079-675b0d7d1bd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "37a05ae8-53ea-48bb-af84-a4ec74cd5267");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "80b9bcf8-fcd0-4c99-bced-c8519f16ed2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d9c4a79f-9214-40bd-8bbc-59da9f0bf003");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdec5d2e-4a0a-4bb5-9e30-a0b1952667f5", "AQAAAAEAACcQAAAAEC+H5ueVgnlZ5RLsCI+lZjnyHwLC3WloUhj1b+2fb3uttOd3lt2cOBkx0yK5rtWdHw==", "9c27bff5-9759-41ae-b956-a190e71f095d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a50dc6a-1b5b-4855-b9a8-21c0a295dfd5", "AQAAAAEAACcQAAAAEByI5gDxVbWY7zq889dmvyfDDVmZcmMm57YfQj+0R107hb1n0ZYrc6rp7zGB2yKWgA==", "446ba3ab-900f-4e76-be30-f7740b99dd5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2e3bf4f-bc1e-48d5-9af5-94cc1a21bcb8", "AQAAAAEAACcQAAAAENmGmnDTHPwcmf19s/G1CyxCGdIAndbAXoFnd1KJVCDa2XzwK8myRVuDsfWvvkrevw==", "ce20a3de-41bb-495b-ada9-668f42bd68cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897711f0-cea3-4ccd-a235-3e2b3c5bac99", "AQAAAAEAACcQAAAAEHuvoEbJwW3/cXLdndzviVOq2p7+0ie+womiW3i576vCOZx2tR8lFRESkBDnvZ3lgA==", "bfa772df-1d73-401e-906a-d2c1d522dff7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a29a7e5b-8fd8-455d-87d4-49dd25238b65", "AQAAAAEAACcQAAAAEF3Cb/YmD3FXCeMGQRgwwAtPqW5ueZOZRXLcoK+U6/q6Q8VRL8LU9dEB5Md5+lwQzg==", "55b9b7d1-558b-4fcd-a7c1-677a8b55d98c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd62c420-51d0-4a46-8016-cb5c974a3724", "AQAAAAEAACcQAAAAEEBD0I/LkczXIR8kwKeGTRbfhBr0EnNd4CS/v2Gyyv52OtZMDQ30W8qqFFe0/STCEw==", "0732208c-ba2a-437b-a54a-ba449d34c5fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec0e37e4-22d4-423d-82d3-0e84cddae1a3", "AQAAAAEAACcQAAAAEFbeBS/VJjfe98MqH63rhIxiaRVPvkjd7+MTqGETMsjnCv2aQZEeLgt5EQIO1hT1tA==", "f620005f-67c7-487e-9ab5-4bb526d81b74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063fe9ff-c421-437f-8628-6197c7d901eb", "AQAAAAEAACcQAAAAEFVLIrPwr1T3RGgtm2ohQSeVqE6PP/9AAup7/zqX2x3QnLwUrHYmjCA2LosZykesiw==", "5c838684-c755-4efb-9bbe-7b4efddc916e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7758e68c-9e6f-4055-8feb-3c185783867d", "AQAAAAEAACcQAAAAEJdoq4O44edZBZqc+kB9gyM0YwlcmEffPcboG3xbgLhYVQUSnOEr9xQ3dHQaTJThKg==", "41db6f71-8ff9-439f-a3f5-5154e7e2995c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abf2b42c-db75-41d0-b411-24638ff6cc39", 0, null, null, null, "e640cf34-1058-4cce-a4b3-346fe8a896b6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGbm20ze5/sWFtHd8JfiE0zq76YphEazgY8GJIe9Gye5LiJrdcf0mJgWBU2mQc4uxw==", null, null, null, false, "1", "0001113", "b47f13d3-6809-4576-995d-57c233c94e51", null, false, "mishka@gmail.com" },
                    { "cc8c8a04-cb59-448b-95f4-7426f044c881", 0, null, null, null, "e6b90c84-11a8-43f8-9582-bc27906fa549", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEB07kxUK8V0rzc1VtHrkTdf9gdhk4SQ3ywijagc7WhV8bsO/lG07RTFQMKTGJ+WWzA==", null, null, null, false, "1", "0001112", "88c38c85-1eca-4d6b-9930-cb373577ea5a", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abf2b42c-db75-41d0-b411-24638ff6cc39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc8c8a04-cb59-448b-95f4-7426f044c881");

            migrationBuilder.DropColumn(
                name: "EndDateTimeStr",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "StartDateTimeStr",
                table: "Hikes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4105d67a-e94e-4ef0-9c4e-5a2170c01373");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "849a2883-ce7b-4f72-a5a1-71c5760fbbd1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6ca8a141-4b9a-4a49-ab22-86d384e3fe6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "065a761a-5e43-4144-9b16-96f5374d907e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b339f96-d4cb-4195-9df1-32b54b3a7450", "AQAAAAEAACcQAAAAEOc0X7jVDI20FnAnBvPXUEVJReoNMmSYG27fPmlJwqEKqew+CEeZEORmS+dX7+jefw==", "ad5b9e2b-e14e-4f25-8ded-8f96168454d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893bd8c0-51b5-4cea-9a8a-5e404bfbe297", "AQAAAAEAACcQAAAAEG8K3R22tCzxoAh9VN0ALWLAS/peBieEqOEbu1w+PHLfxAGlBVDrimtgf9LWdAdwvg==", "aa38f2b5-f16c-4ba5-b087-59ed86c57fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8800de72-f8d8-4e63-b903-8311e2a2edd9", "AQAAAAEAACcQAAAAEAQDXpTZ41f/7if/CecVaSNcxODmhfOVPvx2a5p5DxyN/abrn8B7Qn4OUlFpXvXYPw==", "c34f09ca-acae-4dfa-a0c9-73f78bb1b472" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8632b24f-2d30-4878-ba5d-7773697f6232", "AQAAAAEAACcQAAAAEFOjoMBpDcvJXH7+p2QgpA/iYAjh15D83ois4BHUjhR9ITL+pGqVwmWVq6zPxcbgLg==", "0edc7989-1a1f-43de-8266-fcbc7fdb93da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04193d95-7b76-4327-adcd-afa288795db8", "AQAAAAEAACcQAAAAEMeCqMyM6H+ly13lNCIP57pa26xpXFiAbGjpCPzb1rTn+/vcGFIzs59eoXP/Rd9w+A==", "247c4c9b-ae1f-48f7-b74c-658fb9cc3e74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5699cca-7363-4c17-a18f-d44cdf20c556", "AQAAAAEAACcQAAAAEL+w5jYJ2X3N1TgFBxIuoRv8RXLJsWe8wzy3sH0FI3oNgdSsMbR4MrXwebewpY7UiA==", "e7295b12-68a1-4264-b9a8-5983d6a1dec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc99d116-f123-4c73-9879-7aff3b10cc6f", "AQAAAAEAACcQAAAAEMtnUACylakgfcQ+QFxkr+Gcz1fsqGjLo4q0qe4V/6+6DVz9TP2/vm2x6YNcZDXy2A==", "d6e10dae-660e-4781-98ac-20bcf88baa29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ca390bd-d2e5-47ff-b5a5-ca9a39142c16", "AQAAAAEAACcQAAAAEAU5bQ2f2pGYeVdtuJp29esjztWkT3BFOVMu3H2ZmJBoFsXayTUwEYAo3YrMZ02FmA==", "703b69ae-c6d3-4770-b05e-8d5618cce673" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c946944a-d53b-4876-8067-e6f8d5c21415", "AQAAAAEAACcQAAAAEJklFNHJuZ0nPlYlJVmrjgYA2Rfl9bzTXN1QZAHLorjZCoGgOddgpjyadE0At+0nFQ==", "a7d950e4-e933-4eb9-8305-d477c994b46e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ea0a81f-af62-48bf-b24d-9eeebe96e657", 0, null, null, null, "fed5cf21-36f9-4c1f-b54e-ce3d7bb4d25f", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHGlhL3bVumSdJvuwPMIQOK4OEKGyUfdb40ET3uIBYWOpj9OG7D+wbg9dKVDGv+QEg==", null, null, null, false, "1", "0001113", "54648e41-9d5b-47e6-9fcf-7e8b2e41f780", null, false, "mishka@gmail.com" },
                    { "7630c52d-5b28-448d-ae4b-b22df361e3fc", 0, null, null, null, "f61f84dd-6149-44f0-ba0e-f6bf9ce6a06a", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECGM+i8Cm4i+Cz2KiuaPshMPAxfspSR9M4nNpBie4xny8GvMQZMqEPV2K4eGAA1Qrg==", null, null, null, false, "1", "0001112", "a25ef33a-21c9-4d9f-9357-d94353966020", null, false, "anushie@gmail.com" }
                });
        }
    }
}
