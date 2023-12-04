using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class BirthdayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aca6baa-ab35-4361-9c4e-cad266d0c3fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7da35af7-4b8d-44fa-a087-37c03ce9fe19");

            migrationBuilder.AddColumn<string>(
                name: "BirthdayStr",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "814b970b-ca66-477d-a914-a01d5a8d8fe7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a624cc-8d4c-4a6a-ae89-4766d3b08eec");

            migrationBuilder.DropColumn(
                name: "BirthdayStr",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b8233bcc-4b96-4969-a0cb-f321e980bae3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2929ba53-6970-4401-b0fd-c28881229a86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6dd9a818-0a3b-43ca-9128-5bb6ef17518e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d8ea364d-7569-4a68-b0e6-f66b10b858af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66eb13e6-dc8f-4854-9a59-b8d01751c828", "AQAAAAEAACcQAAAAEAYtQalJWmHbpTPdABNDVI7Mg/FA3wz3zJZV72meBwa7cTvF0jbu3JMjwUz6/S0CNA==", "eb82683c-daba-4651-9d29-b3e1a09604f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b163dd0e-6bd7-4e47-9460-c1d526054fe1", "AQAAAAEAACcQAAAAEK1e2iIWGddOY6y2NSnp7zzXRnMd/k3KHmNC6gNBaULNeKC8evO/Zq1uF+iFJDVgWQ==", "9b7f1517-3a2d-4814-80f0-c24506d5c651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6a1b8b0-3d59-4f6e-880f-46ab1317d23a", "AQAAAAEAACcQAAAAEA2bOM4fq+vTTMKmDvv7C65iCTpxB905/pOjRLnqGE6auZ3j99Z3N2pTl2E+waXqfw==", "91770f81-05dd-4769-bc42-c921c8c51d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd84dcba-a7ef-4660-b31f-e95927ea6b9f", "AQAAAAEAACcQAAAAEJjBVzVvEdHOL9CK5PKD/DfrPd6bEKCIYVdUtGrmUvebaABeLZfL7c2I3j/QP57DAA==", "9f708553-4cd4-40b1-ac35-0354a71aa521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4f8339a-a8e2-474b-864f-5f71c317da17", "AQAAAAEAACcQAAAAEKVB6zFnmUVdnW09wyEOEHyrok0IdOoHFVlmMwnmEg5rvlxZ0/cax6D+3x1t4TAi8g==", "06aa84d6-a091-4bed-bd47-437643691e4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d12d8ae8-045a-4d15-a6c2-97d82d816602", "AQAAAAEAACcQAAAAEO1yyfIZL/iqrshzfGrezLoIwvdOy9OxdYkULKkKogmqWa6uWjT8uRBD2AWHiPhPfA==", "9fbf0f6f-8e2e-4926-bdc4-14683cbfbdaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d8732b-c1f7-4bc0-bd8d-d68234fce298", "AQAAAAEAACcQAAAAECD5J5cQ12uAYHXtfIgoyHGb2a/WGZPP9sPcZ15S6Eow3Q+vI91IffC9XdIFZ5gphQ==", "c3771fed-80c4-4d63-aa7a-e82b3d405010" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00c76d94-507c-4649-82b6-821df4dc099e", "AQAAAAEAACcQAAAAEN+87LiKYMa7LZYPLadJEH9QC3u3DjLaN4RvnmuZ4TliKjjz5c29jLy/ESvhkHsOHA==", "9b77fff4-acf5-4c31-a4ae-7e1276efa1fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62647928-f2dc-42b6-9a22-2e3e51ef91be", "AQAAAAEAACcQAAAAEBO2WEniUcVZmZlS3I+/hcH9bbykCmT5S6vIwvwi+ChFyosu7CZ//mF4m/tAwC3aWA==", "76272637-378f-4146-8ca1-fa1e9647db99" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3aca6baa-ab35-4361-9c4e-cad266d0c3fa", 0, null, null, "081631e2-1bc4-4987-bee2-d1f85ef828ff", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJ7orAMP0vbwCHWgnzWE0p0yHf+geZoLCRfh1GmGTXav45qDb3nh6+HoCtTFAwEJ4Q==", null, null, null, false, "1", "0001113", "53d0751c-83b3-46ee-8660-97dcaa3fb312", null, false, "mishka@gmail.com" },
                    { "7da35af7-4b8d-44fa-a087-37c03ce9fe19", 0, null, null, "e8a7d2bf-8e24-4c78-933e-534b74f58123", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAENijNUHH2NfAViyfbNPK5tvMMBLd3b751+tzscPkgbyIKrhRdT7caUHRpdGmiv2OaQ==", null, null, null, false, "1", "0001112", "78e97687-1ae2-4614-bd5a-950e5d2e1050", null, false, "anushie@gmail.com" }
                });
        }
    }
}
