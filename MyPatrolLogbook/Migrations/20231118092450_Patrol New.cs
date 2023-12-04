using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27251a34-3e51-4367-a40c-bcdaa5281ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d555a6b-e22a-45b9-9c33-eab11d52af41");

            migrationBuilder.AlterColumn<int>(
                name: "TroopId",
                table: "Patrols",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ff8d6618-706b-43e0-915e-ea1f85262f74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7085167a-bc9d-4f1a-9f80-98080e2437c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c54d8766-d526-41c4-8cf2-4a36d3a2165c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1ad82f97-da6e-432e-9c9a-c8cb2e3cd8e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ae1d26-b203-4dcc-b6a3-b30a9c45b584", "AQAAAAEAACcQAAAAEHQ0MncGh2ogH3Og5zX0JSJnzGDk2NzPRidt6v9yRW8/rlR+w01CFPjKMjg5TLvOJw==", "5a458813-9f0a-4b6c-b8f4-3de70f4ea526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4af7fc6-55d0-4c70-80e4-1ef3bb310e5f", "AQAAAAEAACcQAAAAEPJwNe6P6MhDIw5e+U+r6LZDjwEEzWiNwdctFAl76Fg6iZSVD+Br8tNLy9DqvIRvaA==", "e81feffc-a368-48bc-a2d0-3dff696e3b17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b8a1884-5d2e-4a2d-bec6-53ef34e32d2f", "AQAAAAEAACcQAAAAEIi+/qFxBR17tiFA667/F2epUz3HyQIbEmvDvM0cFBo60akVvRBWPMaz6TBO64l4HA==", "307243fe-7aba-4ce1-9739-aa7162553ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82bf9e7c-6592-43e3-8be1-5814ff813d6f", "AQAAAAEAACcQAAAAEMipCXuwuVM0OSuFxFMhx4EdhhqB/62lsOWYQePbLzbskXfT64bzRO5mSKUGOl6ZRg==", "926bdf72-6bb9-4871-b77b-7350b84f028a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12f07384-252d-4053-94a8-9d78b12422bf", "AQAAAAEAACcQAAAAEAqVkTs+p/wXz8DuBXNXc19397Cosz7AL1MuZuE4Q+/8FJcgfvd5vB40CmuY1AnLWA==", "8d79cb6f-f82f-45a7-a840-e32b34168a4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669fef49-22fc-4c5a-9f2a-86782db5436b", "AQAAAAEAACcQAAAAEH5uf5fSpt0314juhP+r0um3cVP9i5b9ZYrnE4dEYJX/n3HChos/1WUeTSd3gx5SyA==", "c1e683a3-8b10-4521-a08a-4398e6279b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d95c83b3-1370-4d0f-b0c8-e6890619f096", "AQAAAAEAACcQAAAAEDrEDIptjaIytj7AhEiVW7b7efGL+LNRIDNqpqGDFjpqmhZKDWPPOC2wdL+dnRSFSA==", "c2b79022-93b2-4282-a0a4-41f78ba95b70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c148120a-0e25-40e8-a200-17dfc3869112", "AQAAAAEAACcQAAAAEMokhK3VtmAZ5agvw3JlEWoRdxmFoJ0Nhtz8IIIA6W+h3Rge0OrMWTvimwUX5VGf3Q==", "04af9ce8-e857-4be7-a4c5-963671b6c426" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f6330c7-c41b-4efc-ac77-152be4e0c34c", "AQAAAAEAACcQAAAAEC7faSa0T78pFmVG8dcMVWJ2VO67v0iTRoZkObgFmuKzC4s6bO3MowZmBAj8TGckBw==", "4ef2ddbc-9f93-46a0-b178-e00fe2c8b089" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1043285b-06d4-483b-8394-306b8b2abe70", 0, null, null, null, "7e19109a-4438-4a2c-8dad-df70ca268ae5", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEFp7T3ZHsR21CTpRTvuVCzQuzzFWIPj6ZwuQAtD2jpwqq7TLLic0EbkxvJinYjNFKQ==", null, null, null, false, "1", "0001113", "7ed33584-729d-4c6a-b0f6-dde0bf8d0057", null, false, "mishka@gmail.com" },
                    { "4db2aad0-c080-416e-a394-f8e6b3fe200f", 0, null, null, null, "b929cf9d-88b1-4373-a52e-a860912a4b05", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEA8rZwz2fsq1TYpT7Mz6VUrQGFsDs7ItfOvHe4vI6JkjWsUHB3QW+2cXMXN/qeqGhA==", null, null, null, false, "1", "0001112", "3c72bc9e-f945-4c2e-8faf-d8524bc08dde", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1043285b-06d4-483b-8394-306b8b2abe70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4db2aad0-c080-416e-a394-f8e6b3fe200f");

            migrationBuilder.AlterColumn<int>(
                name: "TroopId",
                table: "Patrols",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a4fc719c-1633-48ea-b3e8-b63d3adabbee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7861d154-3514-4365-9f8f-e776e2e4734e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d4e298d3-a94c-4ef4-86b4-84be7716d201");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ddafe1a1-a9fe-4b6f-90c4-f5b82994b76a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675c56e3-fb48-4877-a763-a2148b013834", "AQAAAAEAACcQAAAAEIpII8vetL8AdXQwb5NYFtIhEOHKhkF38iciFJUzIKoXKHocqfU5D2Pt8ykr+CgW0g==", "3e426963-4fbd-405e-9ce3-dad4a40d4dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6837948d-fd4e-4041-969a-62804dc09642", "AQAAAAEAACcQAAAAEELoS8nP94z834/PeZ06AiLrHtRlgnDrOmvxXzR/ec2CdyEi0Mmjl42UZsDi0TfLvQ==", "71131470-4559-46b3-8a6d-df0b62f9abef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8e9d632-f216-4f37-99bf-41b875937817", "AQAAAAEAACcQAAAAEL2ZqkZRUqUJalkMkJb1QrsiyQyDLsY08L6oErIWyb9nD3clCozGY4juJvP5l5fIzg==", "cf6a05f6-b478-4890-b225-6f43fe4214f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a6e81c1-61b5-4bfe-a9ab-d733fdbc9dc2", "AQAAAAEAACcQAAAAELCsEmwfp/QUrhb8r6QkxvDdYwaF+C31tFSfMnikUXddRiAEFkxPyXRrmTE9EX4xqA==", "9759cfe1-47cc-46cf-b56b-f4e73383b0ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf4c0e5-728d-444b-99bc-1c353aaab07c", "AQAAAAEAACcQAAAAEBSwo2LDWEcCpqRuuIKVnbNOIk0GJ8tqHmxzBhxF8A3iBhhUDdq+eHSV13vYkvm5pw==", "8099d63e-7870-4308-aa83-83217c54fca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6cef968-ba16-4ce9-a94e-cbea428342a3", "AQAAAAEAACcQAAAAEEhgOb0Yb526iuQ72Kr91/PZloQBETTWVTsCC6NXeYehnrwGfBfLig50Qbxcdnm1Bw==", "3382a7b7-ca59-4e3a-a318-41274349cc74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76d13c81-a4fa-442b-8473-ecad62e79620", "AQAAAAEAACcQAAAAEMuROtN6zgJWTLanSmDA0EvMg4Yl9kUSpEBBkSooGfKOB40mZCe/53XNhVn2qusW4g==", "d6f58e91-ba7f-4fd5-9979-f7d6f650918f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6619a653-103e-4112-b408-0937c463c8aa", "AQAAAAEAACcQAAAAEJmKP1oW1RSb79s8ps7vIxdAnQtF9X1BkFmn55iwLAm1UjLqi3sq8M4YD9hCPm3K+g==", "ba4b9392-e638-4288-bbfd-3c896e789743" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4841948f-25f2-4552-90c0-ee1f3f74565d", "AQAAAAEAACcQAAAAEHINTlu/cVMCPUBbLi3psT+2B+yhyIHmF37hR7gUci23kis5BgWpLxT+Tzvx091b7A==", "56d59b5f-72d3-4fc6-a631-2833db84e828" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27251a34-3e51-4367-a40c-bcdaa5281ef4", 0, null, null, null, "fdd42a87-b64a-4705-8af8-737d6635d177", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJKypyUFRUa0ya71xitry+HJrk93FDcPVtLDFnokp23ynH9K1t7VfMgyYEC005WtAg==", null, null, null, false, "1", "0001113", "e989a6eb-e11d-409c-a13e-b5b5f2baf27d", null, false, "mishka@gmail.com" },
                    { "4d555a6b-e22a-45b9-9c33-eab11d52af41", 0, null, null, null, "a8f4c21f-69c8-4150-8625-f472da27b14d", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEMdu8aKaxlu9l6BX7YcCA/UhcHLqfFazlWODjn3Vk8Gtl1Y/K93Q+h3/JxbNgb6xhA==", null, null, null, false, "1", "0001112", "cbb3c701-7a87-43bf-86b9-5889ef513271", null, false, "anushie@gmail.com" }
                });
        }
    }
}
