using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class SSAIDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43236cd8-94f9-4438-a388-d4cdffdeeeff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7140e8-fb16-4e66-9bbc-40098b2bcc9f");

            migrationBuilder.AddColumn<string>(
                name: "SSAID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "a37c7114-ea95-4600-b4b7-c18007abd48d", "AQAAAAEAACcQAAAAEFBZNXxpIdaAh+7mfNEgmZFmxWexThDFBUy7YufwVKBKOoCAWstvQDANJIKQvsAIRw==", "0001111", "325a1aa7-8857-4b2d-ac86-551e8618b5a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "f3212792-2bf7-455b-a762-3e22ee4ec652", "AQAAAAEAACcQAAAAEAyjHrOipQr8ojonBHzg1F+OO9MxAnkrga/fPNjFu8KCBvhnlihIeFZNSiVzMF6nBw==", "0002222", "69628dbf-fabe-496f-86ba-a5d959e6fa3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "3b516230-1474-4ef4-8292-2cdbc64876e3", "AQAAAAEAACcQAAAAEJAfbX45MIA6FrR9IS3jFVH8WNci35RecMBbOV49JB3RhcHTxYv5WQRacrPhFWoHTQ==", "0003333", "e5f56795-ca92-4975-abf9-28815fae21ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "5d9258ca-c61b-4f8e-aa0e-832f36af3918", "AQAAAAEAACcQAAAAEJujCtJ5qlWEeiOionmck01gVzKLCTWnMkccdS15DZIG+zvRoqksaU1u/A7oBNSL+w==", "0004444", "a701b682-0d03-45d1-a495-d60c18d8be99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "3557ce3d-6973-449f-989b-44d380e8df65", "AQAAAAEAACcQAAAAEBV+OjMvwNm83nadMGvNvxIW4hNsiwBTJ4kynXcdkPv2rH+8pbncpCzONui2UkKNBg==", "0005555", "a1ca01f0-2b68-4308-b9a6-0aff5719a5c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "abd2004a-99a6-49b9-95fd-36bc74f6d257", "AQAAAAEAACcQAAAAEH3tDKj1N3h1OBjY0XsZLlnyd6qY8yegb5kGdOirSgfj/VkRbs5w2MgQVEFvYjie0g==", "0006666", "be6a57a8-2414-42ab-9021-f434ffa847ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "14f2f88e-0477-4c72-a9ed-5fe69689fabf", "AQAAAAEAACcQAAAAEP2uITn4WPqNqYBzSAh8n1TsIlXL5lKjD12MnhGddEHAayCjSmC15c5Fl4Rpt/pUZw==", "0007777", "138c5146-c88b-43de-b50d-59399bff3afa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "d83a66ef-ea1a-486f-b0c0-bb970ef085c1", "AQAAAAEAACcQAAAAEJBt2zrLUy50bPX66tQEA9VV7h6/4lFLQGznVLVlrjrcRpsfSvp+0QIo0cwkwnr30w==", "00088888", "b8b68a8b-2689-4e26-ba20-19ac557fa27e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "5b8e04b4-e9fe-43aa-9247-a706a0d8aa44", "AQAAAAEAACcQAAAAEIBEpb3GTNrI2ryOmiZEsy4qPsT+ZoGS2CJXXUKTbh5hgUNc53maLEiYVp5yld1NcQ==", "0009999", "a0a4a331-b30c-466d-ac62-5b6ddc665112" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6fb8a182-83d2-4bc2-b3d1-3a3f79cde32a", 0, null, null, "b2073545-f5ac-4e4d-bf29-c5c8dd60eaac", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEL83TSD8zMv4rSVdJ3rTWEWuLeze0cInm13I+a6HcoBbZgACUEONZM9k4yXU+FJnQQ==", null, null, null, false, "1", "0001112", "3f7b8b82-4ecf-4dfd-b736-c1114fc93599", null, false, "anushie@gmail.com" },
                    { "b47bfed1-50c3-4e46-acbe-df5a1a5049d8", 0, null, null, "724c0506-d280-47dd-a541-c1d7c0c2330b", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELLseM4cHp/0Hptu1mSgWeAsZe6SaJ88qwFqADC1OXzu73+lYNOGs0WZQt1oYjSM5g==", null, null, null, false, "1", "0001113", "062eac1a-266a-4ec2-8f35-d1c5f4ccadbc", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fb8a182-83d2-4bc2-b3d1-3a3f79cde32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b47bfed1-50c3-4e46-acbe-df5a1a5049d8");

            migrationBuilder.DropColumn(
                name: "SSAID",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e3825cc5-84bf-4398-a406-fd92720adb63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "82dd4bc4-d4a4-428e-ae74-6df759bb5f41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2c6281a3-4b00-4911-94d2-5831355413a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0e192f62-462b-4cd3-af60-57b5df0c7bcc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93c7848-d0ce-491a-8013-53d4b6cc675a", "AQAAAAEAACcQAAAAEFXnm7tRaGFdPX5eQEABborzB/Ea8gq+U/8QN1eln/CV1T6MwGCvOU6Nx9bgvA/+wA==", "c7454daf-c20e-4075-8a89-c289b9e342bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25040d6a-8cd4-4116-bb4b-b3e4e687c0e3", "AQAAAAEAACcQAAAAECHK7sci1E+AE5ceOtIVu6aqkqAz+Ut/VMO1Rbw0DBrdn4WRkbl61CYjiXpwzx5SsA==", "255e8e5c-8870-4d78-a74b-8361f2badff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4187cb4f-781a-4400-b71e-55ae15498acd", "AQAAAAEAACcQAAAAEBBmhqApxMH0xRJBeOBZm6n+nrom9WuRVUPaOcIGKNcYTdVE6uEPh+7VS3veYYGwSQ==", "2eebb100-fd4b-43ab-a172-702947a7da86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a2ad752-f298-4427-8411-58ce47925a6d", "AQAAAAEAACcQAAAAEJDSKq6AcEf33QRBW7tRMvVnQOvhoEVTib/CaPbhifY4HfKgt/usvwvgLbDQpWgLfw==", "d19c5a13-ec5c-4d4d-af72-35e26c83e016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32724c7-c01d-40d4-b284-5e72e72ef5ab", "AQAAAAEAACcQAAAAEKijwOob5o6/6QX3WEEAY1S4vvY3Chn3PHAymVd1ygtxEtQ514COefrzGs39v0efHQ==", "e04b21aa-8c3b-4a41-89b7-97a0fb9d0b0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69defbc1-373a-4a5c-acc1-fc3c5725fa85", "AQAAAAEAACcQAAAAEOHVKfQAFWlpjxW2KuVoCvUcCzulQ19Ulhm/FVccouelE8EjUZhozshdOAfZJnq5/g==", "2a4f1ef7-662a-42d4-bd87-971f57fcb5ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4104c792-5ce1-4bff-a8db-0990f2ff6421", "AQAAAAEAACcQAAAAEOsP2/ZNTpZXEM3wV3oDntcAl9c/VTm9r6TBQmItkJUZ+X45Mc3P9xCBsIMXxpxspw==", "301a44ff-3330-4860-8d6d-6f5070c6f596" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b448269a-92d5-46e7-8e19-e109175376b2", "AQAAAAEAACcQAAAAEE8TNDMXGNaj0eKf7Y0RI/1PzYMrVpg+Ug0OJjAY+2zh0kO5BsHsII9PbzMG5VRLLQ==", "a1c41492-17b4-4d1b-b5af-908dc06a6428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "830d7b0d-487f-4020-a9bc-74736fd268d1", "AQAAAAEAACcQAAAAEKquA4s4xry7MzEK4oehjsXPYJZ8C1FPzkTGC5/sMZ6/5mLkt7H76sySP6DjlLy7Og==", "2c6d2dd1-a26b-49c6-a5c9-cb00b28ff9d2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43236cd8-94f9-4438-a388-d4cdffdeeeff", 0, null, null, "9deb56ab-fe89-4d6d-ae93-d84a31701a2e", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKU8cl9dpVdDr5fszxJXxTkNmuPwrk3IHzoy29HGaMdNIpB21nZix8KWpiLHPL+ekQ==", null, null, null, false, "1", "705ec184-8106-4782-987d-df22d548defd", null, false, "anushie@gmail.com" },
                    { "ae7140e8-fb16-4e66-9bbc-40098b2bcc9f", 0, null, null, "b4cc6862-7d9d-411e-b400-163e885cc043", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJmUu+IVMXWgpdfp8IXgOJNvbsR0uE/06+6jbqzfkz4rzRa2hQY5gNmTuGxO4bmAaw==", null, null, null, false, "1", "8d4bd6ba-f123-472f-a047-0268df887542", null, false, "mishka@gmail.com" }
                });
        }
    }
}
