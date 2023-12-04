using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolJobIntMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "494ce1e0-72b8-4bf9-ad3f-506b1c4ffe4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b5a470c-5e4c-40f2-9dca-c1a4abb2f5c3");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "9a968da3-c176-4901-a5a3-8946263a2fcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f1220ba5-0ad7-48dc-b1a8-d5d232b64f4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "92c2dede-a4bf-400b-8b44-01c588034437");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e35be1bb-ed34-4438-905d-3ed2917275a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b7c2ae-fbdf-41b2-baca-4c7beea873e5", "AQAAAAEAACcQAAAAEGtggBIX9g3S69p5WaYKcPUFfrFFml6+XpAt9yvy6xVUP8NwxI1nAh5Oj3UEb+cu4g==", "3dc298e8-9618-46c6-a889-94517d6abf39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30db230c-ca84-4311-b594-51cffe507419", "AQAAAAEAACcQAAAAEH0ayr7nQ8XyPtLjVpuWuaBiIL0l88hTbgRDxxg8TmBQBtveeB5njcXwEEMMc3aRog==", "8882459b-7092-4617-af49-eef3e0015d99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c62d387-613c-49a5-a3dd-1ee4ae1162be", "AQAAAAEAACcQAAAAEFj1BGdxeCqZG2deQGYYB2n4JKtTjCkm0hUyKfTpea17RLzmtwsULPuGcJMoeENXhA==", "2d11dd61-4d48-441d-98eb-ffabeb67a2a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ac2242-2d25-4634-9a6f-40a148c908b2", "AQAAAAEAACcQAAAAEJctl74srE9L9CPDUGc37hiidWC62/32WcWhXISSZRSTAyO24yJSnPWvpgUFFkpugA==", "ecc0507e-32f1-4cbf-a945-5eb68f0d1db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3829ce8f-dab9-48a4-baec-c6a4b1b5c74d", "AQAAAAEAACcQAAAAEDSwh5R2em2hprEZZ2x3KRAOHglrT6gWX9XjcbruUa0PghfnLeDNIxEa265sRJ/5xw==", "e4f61acf-70d4-454b-848f-b34eeb6f2d0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "272eb5c9-1e88-44ba-adda-186387ea4cb4", "AQAAAAEAACcQAAAAEAO4g9HERxMRiRkpsq7j7+2mcYsOmoxWWGfu980WNmqATHhMyZdEBHZpwBq/ejWH0g==", "06e225c2-d7d6-4c32-b719-1f807e0b109e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e49332b2-c1f4-4a3b-924a-2a123b58683a", "AQAAAAEAACcQAAAAEONe81WbnTNYE9GvpGy91K+pt+yqQ6UpZAwgDfsIgoJbD412EHHUsopnc9ArYF6eHA==", "3b70ca32-16d1-4522-b0c9-03214a032ad2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16af93ef-218c-44b2-bd61-7e3595b7a2b2", "AQAAAAEAACcQAAAAECXZJyGRojvhVZ6/Dy9+Ne3khUu1wkD2sSbxfbRwUq6HyqqLe4yP7xviIUQlLFGmkg==", "2fb15fea-5c98-4225-87f5-1fda74d02a9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b92e86-59d9-4f33-b8ab-1a12d29d690f", "AQAAAAEAACcQAAAAEMeXimF9tSilb2PIhSeLGdxT9+81xUmiGaM83r7VHX+LqjDetSChUP7vzsuOb2sHNQ==", "ab303385-bed8-4f7a-b602-c69082c89618" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "494ce1e0-72b8-4bf9-ad3f-506b1c4ffe4e", 0, null, null, "36a4ab3a-3f87-41c3-b763-1d986ba1f537", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHm615DTvcX/opPTOBefwVHZa4Fi2hjzwJ35CtBn/wxzP5TVcM37gLwdv8boNnnxMA==", null, null, null, false, "1", "0001113", "41adc73d-5510-4bcc-bd6f-794a7480b4b0", null, false, "mishka@gmail.com" },
                    { "9b5a470c-5e4c-40f2-9dca-c1a4abb2f5c3", 0, null, null, "88cfe6e8-bcdf-4029-90cf-8afd692750e7", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEOjfSADmUyFqxlHxP2LLpp25sSuwFia7JD3P61HbcPYgNU4rVh7fKmHGwgCIS2uAXQ==", null, null, null, false, "1", "0001112", "051f435f-d561-40e8-a85d-fa473cc1f524", null, false, "anushie@gmail.com" }
                });
        }
    }
}
