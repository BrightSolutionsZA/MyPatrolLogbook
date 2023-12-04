using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PermitIDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fb8a182-83d2-4bc2-b3d1-3a3f79cde32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b47bfed1-50c3-4e46-acbe-df5a1a5049d8");

            migrationBuilder.AddColumn<string>(
                name: "PermitId",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermitId",
                table: "Hikes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermitId",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermitId",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "494ce1e0-72b8-4bf9-ad3f-506b1c4ffe4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b5a470c-5e4c-40f2-9dca-c1a4abb2f5c3");

            migrationBuilder.DropColumn(
                name: "PermitId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PermitId",
                table: "Hikes");

            migrationBuilder.DropColumn(
                name: "PermitId",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "PermitId",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c48e9be7-b07b-46ac-9dd3-cadaa41dc2aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e6c378c8-eb49-4db9-8ea0-f4fe79ac9ff4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2eaf7eb9-ad83-4344-a822-420b58de29a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "505462be-6a2c-47c8-9e60-6b4a7a9d12e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a37c7114-ea95-4600-b4b7-c18007abd48d", "AQAAAAEAACcQAAAAEFBZNXxpIdaAh+7mfNEgmZFmxWexThDFBUy7YufwVKBKOoCAWstvQDANJIKQvsAIRw==", "325a1aa7-8857-4b2d-ac86-551e8618b5a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3212792-2bf7-455b-a762-3e22ee4ec652", "AQAAAAEAACcQAAAAEAyjHrOipQr8ojonBHzg1F+OO9MxAnkrga/fPNjFu8KCBvhnlihIeFZNSiVzMF6nBw==", "69628dbf-fabe-496f-86ba-a5d959e6fa3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b516230-1474-4ef4-8292-2cdbc64876e3", "AQAAAAEAACcQAAAAEJAfbX45MIA6FrR9IS3jFVH8WNci35RecMBbOV49JB3RhcHTxYv5WQRacrPhFWoHTQ==", "e5f56795-ca92-4975-abf9-28815fae21ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d9258ca-c61b-4f8e-aa0e-832f36af3918", "AQAAAAEAACcQAAAAEJujCtJ5qlWEeiOionmck01gVzKLCTWnMkccdS15DZIG+zvRoqksaU1u/A7oBNSL+w==", "a701b682-0d03-45d1-a495-d60c18d8be99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3557ce3d-6973-449f-989b-44d380e8df65", "AQAAAAEAACcQAAAAEBV+OjMvwNm83nadMGvNvxIW4hNsiwBTJ4kynXcdkPv2rH+8pbncpCzONui2UkKNBg==", "a1ca01f0-2b68-4308-b9a6-0aff5719a5c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abd2004a-99a6-49b9-95fd-36bc74f6d257", "AQAAAAEAACcQAAAAEH3tDKj1N3h1OBjY0XsZLlnyd6qY8yegb5kGdOirSgfj/VkRbs5w2MgQVEFvYjie0g==", "be6a57a8-2414-42ab-9021-f434ffa847ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14f2f88e-0477-4c72-a9ed-5fe69689fabf", "AQAAAAEAACcQAAAAEP2uITn4WPqNqYBzSAh8n1TsIlXL5lKjD12MnhGddEHAayCjSmC15c5Fl4Rpt/pUZw==", "138c5146-c88b-43de-b50d-59399bff3afa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83a66ef-ea1a-486f-b0c0-bb970ef085c1", "AQAAAAEAACcQAAAAEJBt2zrLUy50bPX66tQEA9VV7h6/4lFLQGznVLVlrjrcRpsfSvp+0QIo0cwkwnr30w==", "b8b68a8b-2689-4e26-ba20-19ac557fa27e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b8e04b4-e9fe-43aa-9247-a706a0d8aa44", "AQAAAAEAACcQAAAAEIBEpb3GTNrI2ryOmiZEsy4qPsT+ZoGS2CJXXUKTbh5hgUNc53maLEiYVp5yld1NcQ==", "a0a4a331-b30c-466d-ac62-5b6ddc665112" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6fb8a182-83d2-4bc2-b3d1-3a3f79cde32a", 0, null, null, "b2073545-f5ac-4e4d-bf29-c5c8dd60eaac", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEL83TSD8zMv4rSVdJ3rTWEWuLeze0cInm13I+a6HcoBbZgACUEONZM9k4yXU+FJnQQ==", null, null, null, false, "1", "0001112", "3f7b8b82-4ecf-4dfd-b736-c1114fc93599", null, false, "anushie@gmail.com" },
                    { "b47bfed1-50c3-4e46-acbe-df5a1a5049d8", 0, null, null, "724c0506-d280-47dd-a541-c1d7c0c2330b", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELLseM4cHp/0Hptu1mSgWeAsZe6SaJ88qwFqADC1OXzu73+lYNOGs0WZQt1oYjSM5g==", null, null, null, false, "1", "0001113", "062eac1a-266a-4ec2-8f35-d1c5f4ccadbc", null, false, "mishka@gmail.com" }
                });
        }
    }
}
