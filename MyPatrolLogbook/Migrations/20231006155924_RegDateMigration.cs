using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class RegDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "814b970b-ca66-477d-a914-a01d5a8d8fe7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a624cc-8d4c-4a6a-ae89-4766d3b08eec");

            migrationBuilder.AddColumn<string>(
                name: "AttendanceDateStr",
                table: "Registers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "888d61ba-54e8-4df4-b762-e4e0ea188bee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e026a844-5e9c-44c8-b50b-ac3be45a0bd0");

            migrationBuilder.DropColumn(
                name: "AttendanceDateStr",
                table: "Registers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2845d111-b0f6-494c-9b91-062f01f6d222");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "85ce110d-c5d7-45fc-9b5f-ecf2cd0c593d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9a1c5e55-21a7-4c4f-8285-0b776887698d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0b327cec-de9f-40b5-8353-e9fa3d6e0f7f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39184dda-ba13-4a47-8a09-5b11511ff27c", "AQAAAAEAACcQAAAAEPdwOGgazo/bGttexTGuPpwsdUSIe82hnHzsZRRPVFThaaDGCPoj55WpeLify0KgPw==", "4c502b9b-8db9-4fdf-9881-75c0bab93cbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e222758-997c-4ed9-9c0e-63b68ee2541e", "AQAAAAEAACcQAAAAENaZgodZDV47vrQESRGW2Z5+Hdd2qjsSoBXtXzsJxL5rKNXmRUQdUuQ47lKKDlsafA==", "45a006db-7e97-4acc-a057-859c2fefcedd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7cdc821-31bf-4608-b615-27d1f05b406c", "AQAAAAEAACcQAAAAEPSLGKWFAWkPT9oYyc/bkjx56fBtquIE4m7Rz5o4oqeEqyqbI/kONk4mMOLMDlgO0w==", "8c46c225-00cf-45e7-9e58-11fb3cc0c295" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04964cac-6983-4508-a5ef-c64d10f1606b", "AQAAAAEAACcQAAAAEOGE+oc+N+ZDyf+n9saYkGOckaZU9dHeL3Y0bRuRTzsZqIFJSusB8O7liVHIqVwutA==", "522eb2a5-5c49-4a49-aea8-73caceafa304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a650472-f430-4e31-8d01-8d33f68f29f8", "AQAAAAEAACcQAAAAEMNecVOYXaYpDPdiM6zB6pqrO3oir7crK1ebtFAybI/fBEbmEE+p9RQC47+8am5VKw==", "bb7161b7-20f4-4b7a-921e-7b60fba7b292" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0002f1-885c-4aee-b88c-7015d6806f3a", "AQAAAAEAACcQAAAAECyjplbWtlnW3orgYZ6tsuTnYjCoLtX2kKL9bHmXfgTCLlboSkEvLOfSr/MmEF0MsA==", "0fac2725-a18a-4e7e-a125-5d0f5ab7bd8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "647c59b8-2ab7-48f8-84f9-bee2967670ed", "AQAAAAEAACcQAAAAEFiT0srMqF8c5Z6bXgrKsC+g5CWZrivGBCossTiEfmjLg9tVkaGu0q2nWHBaExADIA==", "7b647b59-216d-4b38-8771-b8d3fa399685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaf75d27-0dec-4920-9d35-a9e1de401021", "AQAAAAEAACcQAAAAELREuxHJkLOIryaL36x/RwUNF7s1wdV+sctnlFpZWfidW1jbdyQyJ8ekXacYyWYlVg==", "3d41d38c-f97f-467e-8abd-a3e2c681f3ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a260f58-8784-4318-ba27-766da2fd20ce", "AQAAAAEAACcQAAAAEF6NAsJEfib8PChlRwcn5tq8x80sHjOnoGyQ3SEd4Nwjiv5U/lVFRFnqJxPiSA/NGQ==", "40c650c8-f3c5-485d-a826-edd8fd4e5cf0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "814b970b-ca66-477d-a914-a01d5a8d8fe7", 0, null, null, null, "f467929b-35fe-4f89-85f3-ad5525d92f40", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELkuaaHEnXbQA7uhFGdsPioJEB5TxhPk1GSOHyLd907dmK13wthQlUu7QmjgvR0pOw==", null, null, null, false, "1", "0001112", "5d1aa3aa-1adc-4280-9b82-cab9b0518682", null, false, "anushie@gmail.com" },
                    { "c1a624cc-8d4c-4a6a-ae89-4766d3b08eec", 0, null, null, null, "9c819a0a-f4c2-4ad6-b44c-17217603297e", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKeFgEDgo5UM1QfAwVXnlO8x+Q+WaYmtACq+q+4GqhflmJ/6IP/kn/GpePEsZHaJiQ==", null, null, null, false, "1", "0001113", "6e2af09c-8802-4f06-8a5f-4f7aadb707cf", null, false, "mishka@gmail.com" }
                });
        }
    }
}
