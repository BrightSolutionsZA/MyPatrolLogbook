using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369a660a-816d-46e7-b46c-69e135982704");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cad2cf49-dad3-49dc-af22-e6f7008e1410");

            migrationBuilder.DropColumn(
                name: "PatrolJobInt",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aca6baa-ab35-4361-9c4e-cad266d0c3fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7da35af7-4b8d-44fa-a087-37c03ce9fe19");

            migrationBuilder.AddColumn<int>(
                name: "PatrolJobInt",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5fe3a5f5-0041-4c10-ab0c-cea7183dc9d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "190f0429-082e-475d-9af8-ab08f264392a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "089e2cc7-19f3-453b-bf0d-26f82310f14a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "fd2b1955-8a64-40b2-8573-469860571e76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62acd4c8-532a-4b92-960c-9330bf15d2f9", "AQAAAAEAACcQAAAAEKTmjWWT72eD1mm0aG18y2MHf0ujsL3aKyWw/Lz0RZoiVwNZ87vGqMKVGOrTN3QFfw==", "e79d7b47-ea78-4b74-b633-36a168a6f261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d441e7d-0846-4e56-aadf-d3df49c0b1ed", "AQAAAAEAACcQAAAAEJ2cVvAxaVz8S1Kal1kQpSVvysVon87nFO989sBs1JKHXQKQsss0IYdXDw0PzoIG+Q==", "6cdec195-fa3e-4c08-9666-e535aa12869b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a367ec-9d36-4481-a168-cd984ed95e3f", "AQAAAAEAACcQAAAAED5QPuXcV3KLXcgRnxq7ZG7+QcxukmHuQu2xcVZd4inIQCtU3PXznbV/vOgz4VKXQg==", "fcee03ff-67ff-4ad5-a379-149c03700097" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f5483c-589b-42a5-86f2-74c11e6b5d32", "AQAAAAEAACcQAAAAEDJZutk7d78I944mSaMlI06/oHtvIuC5BNc0qZukjifIbWHWf7wqYCRcjUhdej9KJw==", "ebde5546-8d89-441c-8b03-639b2419032c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "780114e0-19e6-4db8-9e88-29bed35f620c", "AQAAAAEAACcQAAAAEPHt8J/5UY6LWq9dLvq2K0/8OgWq1i2RXiSnBkcJpEGCqDoNAym34qgomQChNsfH2g==", "84a68e20-af64-419a-8aa4-fabf1b5093be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eb37923-98ea-4c2f-8fdc-920850848a0b", "AQAAAAEAACcQAAAAEBEtpSMW5CLnxaJ9vMvbe/XpTrFXxYzeAPzszaB20IhWES9PlW9I7+BbKgW4878O5g==", "47b4665c-eebc-4226-99ee-6949e0e8e475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a81b8e3b-d180-4b45-b9bd-a44071b670bc", "AQAAAAEAACcQAAAAEHPzmO0vUaJdazRZfknEN/cyIC16maXD7Z3bACEAAfF4N06zlYbgy+CglRwwVCveog==", "ca7ba532-2ce7-4ba5-b4ad-02d63e416c88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f6d9a1-be8c-4856-bb7f-9794929ff353", "AQAAAAEAACcQAAAAEDXENF5it5b2+zK7nXnXNee74QxtP4vstMSpyfVPOjzeI+tuc1P2vbPphYbKUvOsrQ==", "8d292b0e-bb58-4d2f-96c2-a64fd2b3afa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25f04f6a-39ef-440b-8c70-f99947843c80", "AQAAAAEAACcQAAAAECD+pakhw/nDCW0nU22ZbX5yq5VtYsOT7JcM0tn7mUH1z9bEAdtV+GuOSLlwmg09uQ==", "08a05bfa-9021-4f94-a90c-eb62d6dd3000" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PatrolJobInt", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "369a660a-816d-46e7-b46c-69e135982704", 0, null, null, "f07748ba-0efc-4e44-b8d4-63aa498b83a5", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECyWfjahkRKiQ4wYAcjvtagUInIznNaDhVnC+W4pLC0m5Q6zXz33/yu8qVBcOgecjg==", null, null, null, null, false, "1", "0001113", "eb248c16-c392-4c23-8da4-ef90b1187a06", null, false, "mishka@gmail.com" },
                    { "cad2cf49-dad3-49dc-af22-e6f7008e1410", 0, null, null, "44ce98df-ebbf-488c-8f83-3ff5c4fb2623", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKviR/aINxM7yLYe/T61GbUHnYHiaC1g3HMF7Qqj93hCkMMQGvu9mD4/SVEgFI7iSA==", null, null, null, null, false, "1", "0001112", "ce281c3a-0eaf-496f-a8d4-87b7fde1ae26", null, false, "anushie@gmail.com" }
                });
        }
    }
}
