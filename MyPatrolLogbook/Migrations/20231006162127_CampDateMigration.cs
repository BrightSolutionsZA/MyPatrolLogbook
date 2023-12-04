using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CampDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c38471d-988a-455a-b4e2-57d8303099fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7c582cc-d84b-48f5-aec8-812aeb2212b6");

            migrationBuilder.AddColumn<string>(
                name: "EndDateTimeStr",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDateTimeStr",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ea0a81f-af62-48bf-b24d-9eeebe96e657");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7630c52d-5b28-448d-ae4b-b22df361e3fc");

            migrationBuilder.DropColumn(
                name: "EndDateTimeStr",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "StartDateTimeStr",
                table: "Camps");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "379cdb5b-f87c-43bd-90e6-2c5e27c531fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9f11a850-0a39-4de3-a568-b94b00a0d600");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "38850e1c-1d23-4559-9395-50c1dad89b7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "4c3e8caa-5def-4cd0-8ccc-a92d865b6abb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc6bba37-002a-480b-bd6a-9fdf635b7cb1", "AQAAAAEAACcQAAAAED7CxIqsGx40OdWgygDuk8dkES44ao2JytcaoQWoDixQTX7qJnYFWWsEpj0GDG1H9w==", "b8023389-08c4-46f8-b046-3b71e5be80c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed4f5fb7-155a-4c5c-bb45-f4412ef879ca", "AQAAAAEAACcQAAAAEIZXZGPG9BrAA43ORiIazXBGK9bwrJTB2qy+3O+kbCzfO0d0XkFNoTqy5tNV9B6iVQ==", "4ec7ae89-d544-46e7-b710-0a44d072874f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e790bd73-8b92-441b-ad5e-d234af4e7eca", "AQAAAAEAACcQAAAAEK+bBmF8d2ws8gwVoAuPT0hy0Qt45vwX36RiN7HEoJDeVCmlJQYpGLgiv4/4IW869g==", "8120e5ac-0b53-4fe0-9ec2-c9d8d4025e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58154c9d-56dc-400e-afd4-baa974faa4b4", "AQAAAAEAACcQAAAAEAfss7gNYzPs5qqHAOTf2FyBTOx+q/5JuNVioz2MmZyCGWn6ahZLV9Gb7lbr/GEyfA==", "d486cb02-6507-447e-b02a-ae78c78b6187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45bfc89e-2a30-4cc7-9424-6f02bc2a29c5", "AQAAAAEAACcQAAAAEFPP26By+79At5hlHnGYfNPm4aAPscCoTMSL0xnahrpnKl3SQe7Dh/wsBlBtL1VbLA==", "d34dd2d6-ecf4-40ce-a5d2-a97096ca7a27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bec776b-649d-4be6-a54d-662eaf1fc68e", "AQAAAAEAACcQAAAAENIYuvHvQm9rjZtqLHShS3kgu+06/yVhSq+/1ZeNwNQjMmVBkTnBxdJliYcD3Od/lA==", "33cdebaf-73fd-4dd1-9609-aa82877044be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a42efb9-ec0e-4afd-96c1-1abd8a15330b", "AQAAAAEAACcQAAAAEOtHp2SldmJw3EZe6mMAtHB1WpvuaT8uyIsMnWk4ncmcqtEAN5fLxYRwhNrjBGeTMg==", "0f284fc4-b105-4881-a9b1-e843d3067616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13bfe53a-ddbc-4bcf-9294-98fb27c6ed57", "AQAAAAEAACcQAAAAELMQV88H4D0I4A5CMyWJEG8gu5m3xwNq7nIdgTqOw0dbwQzwNbdW6n6ecD/a9BgEHQ==", "7f2a3a91-cc8c-4564-9165-fc8948ddb356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29d16ed1-34fc-4106-87ff-1ee4e79c3df7", "AQAAAAEAACcQAAAAEOHgRPlzIXsH2ksgqo2pCdtXk4XGtbQtEem/J/YEAD1x+r2Doc28fi5VPYQp+J9M+g==", "bf43e504-b071-42ee-a6c0-d7ce3ae2053b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c38471d-988a-455a-b4e2-57d8303099fc", 0, null, null, null, "04d07508-21a6-4214-b782-6996b51e2df8", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELMeOH9bSD/OEBQEsKfM3i6ya3IG/H4S+UiLkJd5JzP0/GJoqtw0JHeE9kD3ly2Npw==", null, null, null, false, "1", "0001112", "432f8809-5a67-45f6-8abe-a80a98bfd2ef", null, false, "anushie@gmail.com" },
                    { "a7c582cc-d84b-48f5-aec8-812aeb2212b6", 0, null, null, null, "f97c06da-49c2-4a61-9c31-ce0e61bfb01b", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGtCARDjNYIDFtopAmqS7m+h9JGACrwoY+MhaZdo0lgNgT+y6skZ5+IfJ0xjEsy5NQ==", null, null, null, false, "1", "0001113", "31249815-c015-4d36-a445-9f527717f6cb", null, false, "mishka@gmail.com" }
                });
        }
    }
}
