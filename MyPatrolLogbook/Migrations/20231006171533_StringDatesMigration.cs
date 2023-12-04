using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class StringDatesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4320fe56-4441-4d26-974e-4b4ecee51b8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7f00d1-c6eb-4890-8210-067709390aff");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27251a34-3e51-4367-a40c-bcdaa5281ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d555a6b-e22a-45b9-9c33-eab11d52af41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2edf1f18-317b-41e8-94ad-751aeb079ff7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "95f974e3-7682-4920-a598-3beb4abcc086");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "218d6610-cbc5-4868-8d64-c676f025f214");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "384fafd2-4809-4268-9877-276471b63f4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b72445c6-16f7-4d49-94bb-9b47976dc340", "AQAAAAEAACcQAAAAEH0hHlynTuARB/o0CQjjX0ghyM+L/e88vaiTC6U/IQVY/i1Iy/XpqYuIMeUq4cOtng==", "e322b04e-2642-4f92-b8a3-4ca10f88088a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30e8df5c-89de-43b8-aac2-165f9dbd7181", "AQAAAAEAACcQAAAAEO4ime2fo5aNm4GM/DfLkFLcR3szwd4j1OdeRGiiBGcOzEy8TjIUWJuY+fgTZmK+0w==", "42aa02c5-424d-4d65-bac7-4f2e726c3448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3730b50f-c247-4667-ae83-64933f9efe1f", "AQAAAAEAACcQAAAAEEgok08WPd+PsqX8No4G1C2V4QbVCCuI8NKFEolGCzLqZfzAuUonFjUtA/0tsopgFA==", "6d5cce4e-9b73-4e1c-802e-38421591effa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c84ba79-ad6c-4ef1-8acc-52602a03aed7", "AQAAAAEAACcQAAAAEMc1VcxxmjZ2HKLnXeAph5gGQkjf1aCTUOCWNDO3SsSSBt5WvJLRZ7muZVOhXFnnCw==", "461dc112-c2c4-423f-9116-e32fc06975e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb78015-96d0-47c5-bf12-517d51997c74", "AQAAAAEAACcQAAAAEAdlC23jklvjU57Ja4suBg2CieXDKPXUEsoZ9/nQv2MWEqC20I7tFj4Mz2ghmCtNLw==", "caeb2712-b940-47de-8e5c-9b735bce8d80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc82dd4-20dc-4453-82e5-dbada87602f5", "AQAAAAEAACcQAAAAEE2hiyR7eswjkFyrh8lij82BB/bkCMJVV+fRmvUey6UkHMulcc/+YwVhmt4fBdLMQw==", "3883cdf0-e2b9-4743-8964-e7302590b0e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd5626f1-48dd-45b7-94b0-e585d6102649", "AQAAAAEAACcQAAAAEAnAfq0eMYhorNMNR6mAthPzbjfkdrNdAfohI92Xn4h3IsIPnrsPGvNA5pkewkCq0A==", "d6a8cd31-9f70-4cc8-924c-d09dc7feb326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "355a7382-887f-4db2-9e69-80ea45741cbe", "AQAAAAEAACcQAAAAEHsY9YE5Jd9SRG5/uVEb/VqjfCaoajZ7UKRKRiyqjqdMUrdokDdlQoVFIfVnkgkz9w==", "c0405c4d-fc91-46c5-b726-8d8078b5ec34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae75eee1-b225-43eb-a11c-b7db9fe48aae", "AQAAAAEAACcQAAAAEPgW1PQOAn2bvZzxRi6qSNIhy4+pgvG8GAn4C7ypW7DgkIPvLsDJR2ffeFxPyl1OXw==", "00561beb-1755-47db-ab61-a7eada88f905" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4320fe56-4441-4d26-974e-4b4ecee51b8c", 0, null, null, null, "38128632-b829-4bb6-ace6-1eafc8d53d60", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELlGGYkezzFoFVgHzH098+/aYC8h1dhBtttaXtIaXKaMA2koGbvlVZF0hA32CrR+cw==", null, null, null, false, "1", "0001112", "a2a59d12-9dae-44f9-ba9c-e6a4d61160b2", null, false, "anushie@gmail.com" },
                    { "fa7f00d1-c6eb-4890-8210-067709390aff", 0, null, null, null, "89923e70-105d-4911-9c9d-37b1e158681a", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKcoPf6m/CjFtVPpLSQsTM0xLgB8ODbl8sEdq4xkVhGcGmnYiduG1MRtFfuIfPbzLQ==", null, null, null, false, "1", "0001113", "66a38e25-2227-4ff3-914b-8720318fcb74", null, false, "mishka@gmail.com" }
                });
        }
    }
}
