using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class AzureTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e4b4eb4-0413-4ae9-a74a-0b22428b7779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff29d7bd-075a-43d7-9b4b-99c4b73b9f82");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43236cd8-94f9-4438-a388-d4cdffdeeeff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7140e8-fb16-4e66-9bbc-40098b2bcc9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1ea3c385-922f-4eb0-a61e-fead6df1371f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4420aaea-6c66-4169-8663-1cbb92cfb686");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cb9410c4-2d45-4185-b542-152975bae1a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "769e28e1-e47a-48fd-b2fd-3cca38dc63a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f856e4-e58d-4b81-9ed7-4cb2b902e345", "AQAAAAEAACcQAAAAEF2L5D2XpqYIB7TGjOi++8XixNYm97CFnomsbQ6JYCH8c+tE/E5W2VMAWpVNBXY2gw==", "f9122bf7-6109-4de7-a49a-80f286c0e2ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dde3f975-04b4-417e-a023-63791e87da62", "AQAAAAEAACcQAAAAEGOl2bHG2zcasConSjbzWlkQpwQFGLT909BF3EcF4oCbiB87B6wxqRU+foIObLmjNw==", "20f65f32-21b4-4c47-b538-dfcf3fb523aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19e00a5d-bc5b-460e-b322-84b172be7676", "AQAAAAEAACcQAAAAEE8PV3KrKJRrJS2b5lFDu/B7oy1R+VqpKsxpWkoFktO+Ce7nNAe5M4ej90ZZYz5q4g==", "7de69bcf-0160-4428-b902-fd7c0b034041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39761b69-1aef-4754-933f-ebd340e06bfd", "AQAAAAEAACcQAAAAEFhdVvw/BbTXT4mR7sAX2uhQfzG2Wfz8oBBoqkqj2TMjx4ty8qn/GyEuLDm0p7Um/Q==", "4b00dc3a-ba70-4327-925e-755500bbd01c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06b997fc-33f7-490c-9404-004f719adf17", "AQAAAAEAACcQAAAAEOCctLvn1IB1NZYUOwvKiG0fv/jC3cMV1FaqDLYCOqBN4HgT7SlRqYwcuL3OQSl80g==", "64388df8-4094-4c9f-bc88-8a4510f692b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06abddff-26be-4a2d-b489-66e355eb9def", "AQAAAAEAACcQAAAAEJ1OyQjmOPBvsOtcvPDtlZAJFDBtdcTQ5/YleE2flNKqqYbYxfbxMYAAHou7S7vnwg==", "2fad5ef1-e589-413e-9ab5-055831f62bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50157dac-10d2-48b5-ad9f-4ade790b5549", "AQAAAAEAACcQAAAAEMCvOYBuQ2xvZUUnirIZC/ixQd/gR16ybvEp7jQZQQ84V+G5V39939Zdq151f2339Q==", "d98b3a35-227e-4bce-bf7a-867ca9d21650" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02863532-b062-43db-be96-3a272c792513", "AQAAAAEAACcQAAAAEJBFJhWRrdd5v0fwnkI/wkYyD+w82i3OlVNMJa3BEigzApM9iYGC9prz6/1pU8Fa7Q==", "d8563c15-b064-4383-a0a1-3fcad2dffbc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5223cf54-5102-410e-9098-a75823aea1b4", "AQAAAAEAACcQAAAAEMgagLsgTf1KXM7xFAWnIvpfxNmKfzwKvDBTAwY3+REEmcVclfRyZDOptQcyc1fKjw==", "1c5a8598-4417-4918-a8ea-d73f35030ed8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e4b4eb4-0413-4ae9-a74a-0b22428b7779", 0, null, null, "3062570e-6e67-4c2b-8b2c-a1544c8e7f4a", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEP7bQA9NY+ZeYBYfCJEXbwsXj+s/3rF++pdXsr+cNfe8BfMU1viZQA8otWYwR2GQlw==", null, null, null, false, "1", "d69b7249-4c98-4252-9eac-2baf474ce31b", null, false, "mishka@gmail.com" },
                    { "ff29d7bd-075a-43d7-9b4b-99c4b73b9f82", 0, null, null, "e7963671-0f42-41ae-93f7-2500ce17c953", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEFY8FMOZ1K1lAYjL+s3ITsjButImAon7MLTMbopTlkO8lHENI3PXdJa/H42IZISGkA==", null, null, null, false, "1", "c342c604-52b3-44b8-84fa-d34c471e5afd", null, false, "anushie@gmail.com" }
                });
        }
    }
}
