using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PICDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "888d61ba-54e8-4df4-b762-e4e0ea188bee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e026a844-5e9c-44c8-b50b-ac3be45a0bd0");

            migrationBuilder.AddColumn<string>(
                name: "PICDateStr",
                table: "PatrolInCouncils",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c38471d-988a-455a-b4e2-57d8303099fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7c582cc-d84b-48f5-aec8-812aeb2212b6");

            migrationBuilder.DropColumn(
                name: "PICDateStr",
                table: "PatrolInCouncils");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bd62ba54-8f20-4274-ab69-fa070b57dd07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "761f43d8-9b84-417b-8b6c-272db3dd1e19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5f9f8dbb-ed32-4039-b61c-78695cbeb94a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "58cf1df1-dfbf-412b-ae79-d21d8d79bdcc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8f90d74-8b1d-47fd-84a2-3a2f48ad3a89", "AQAAAAEAACcQAAAAEAFSMeRDe14Dealt9MRIHDih4ZaGhhyIcqTJsxoEHQHasmrJCyotNRglPBKiQsb2ng==", "7082f024-60a4-4b49-a29a-e765271203a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdff369-e76c-4cd1-a4e3-0857b807d3c3", "AQAAAAEAACcQAAAAEM/XW3N2HuW/S3O8FuLtD/nWlCNiWWdVkv+sdWNLxBxXegkuZeQUeIpeEvFv/PS+aQ==", "a669709c-7a23-4cab-aa29-0138725579b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a365697f-a748-45ab-b417-7020b4582990", "AQAAAAEAACcQAAAAEGGAHOXHHJSSKX5ELJHERoxPH5NnnFSxlphObrM8k7nS8nyHimrwpu44DNQNMk7YOQ==", "8b1b9cfc-0af3-4656-aa09-0953a9f4e21e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12888b4a-e694-4ec1-87cf-9dabbffb2508", "AQAAAAEAACcQAAAAENqigAwvwSdnPMelKqY6mMbdlhWEhKasMOz0PVJNRgUz40bGvP3kBBg895Ldcm3tfg==", "cbd9b9c9-a782-4e1a-9fb2-6567c8f105ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44ea4a32-bae0-4d85-a1a9-5c04921f7e1e", "AQAAAAEAACcQAAAAEDHM3+YcC9RbdLWS7Xf4E6Mv3SKCvsQHDlrI7bYsD42ep6P/gPGf3/1s7ljy5u5Prg==", "d25f3015-793d-4130-b211-11125a2b0b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143b4f57-ab23-46bf-831d-401a59fff7de", "AQAAAAEAACcQAAAAELK1GWPcGGhO/Tgdbp4shVPOpazzXaK0sbx6rlckUjMIFytRcTRYgL3arXClcO6yvg==", "32767c5b-db28-45c9-935e-f64387f7df14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6942b94-6710-4b16-8183-74d00dca46c3", "AQAAAAEAACcQAAAAEGIpCnHVNqEMz7fsSxG90KEDnsGKsMTAxLuMKtm/ijBOfNAzYL4btl0ERh4TobkZUA==", "50ef316e-8952-45fa-9101-fed05f6154a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c003f2e-998d-4787-9a56-391fa9709e4b", "AQAAAAEAACcQAAAAEA0Qw3BTXbH4hKRpupGMraDNT44/ycvID6cho5pedMvT7pd3Y4DsSS44rN38Zbdziw==", "a4c16ee9-f567-4fa3-9916-a0e932091534" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "786938cc-9852-4240-85a3-5a3e5ebb07bd", "AQAAAAEAACcQAAAAEKcVhjWcBxlFNDsZIvv81nsqDcSwuKsBVbYk48g6d2uk2U9C2/IuJO7oPaqeLJKkaw==", "e6ecb3a8-908f-4300-b8c6-baad9ac8ef7f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "888d61ba-54e8-4df4-b762-e4e0ea188bee", 0, null, null, null, "c36ca93c-cbcb-4cca-96c9-97c72464e1fa", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEOuhnfDEud8p4S4tmE6FYpQmSF6xkw8ShuPkP2oHKI1jlGz/Rq2COsmZZUG9mOpqiA==", null, null, null, false, "1", "0001113", "3b5f5eed-04b4-47d8-ae2e-8e9e3d3a54a0", null, false, "mishka@gmail.com" },
                    { "e026a844-5e9c-44c8-b50b-ac3be45a0bd0", 0, null, null, null, "0252b4d9-5e14-43e8-968e-294d68b412ad", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEFBWlQdaGKr2+cuitGnqLN82GcHWDlqm7P9wAaOI+GVs4Mr5Zm02u2ZojlCKJPSGRQ==", null, null, null, false, "1", "0001112", "89540e8c-cea2-4ca0-8a6e-122b12a30ad9", null, false, "anushie@gmail.com" }
                });
        }
    }
}
