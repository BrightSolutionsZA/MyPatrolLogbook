using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CSDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63dfd482-25ca-4e54-a0d9-fb3b62148cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84412f18-3b47-445b-b6cb-6d6bb88860c8");

            migrationBuilder.AddColumn<string>(
                name: "EndDateTimeStr",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDateTimeStr",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4320fe56-4441-4d26-974e-4b4ecee51b8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7f00d1-c6eb-4890-8210-067709390aff");

            migrationBuilder.DropColumn(
                name: "EndDateTimeStr",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDateTimeStr",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1171e10e-4985-43cf-a832-4c8028dd6541");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "477c178d-a232-4649-8425-6ce95bb30b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fa903104-767f-4a7b-8dd7-ac497c5180e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "4e6b5fff-cd36-4d8b-85a9-d4510fb88292");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b02db3ad-c985-4c7f-aa31-8aa4fe19d28d", "AQAAAAEAACcQAAAAEJlpf2HrxiwCiKneOWYFNQWFl3JhDVrfa2M3/1NcyKll1N/76uWl0ALPIRLPMu9UWg==", "0e992bfc-6561-47f0-99e2-db71409682e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc14dee3-956d-4c9a-8599-c2afce01ec46", "AQAAAAEAACcQAAAAELG07E/fym7S128NEItR0jBk6sHEefAJbNevTN/KbOwiUIPAi5Be1RkbwWFQGl51lQ==", "f709a3e3-85ad-4bee-93e2-649d77d57b8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a71bf8ad-ac04-4265-9c89-3c42d1c94f46", "AQAAAAEAACcQAAAAEKKYO716B5r8d9wLa81Gj94PJEflnynXd64Wwxn5lVZVERtcXNrQXZzixryBn+jl8w==", "ca63980e-455a-4e97-8970-8cb258fe9db9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67ed279e-0229-4a26-82c5-3d54c13103e4", "AQAAAAEAACcQAAAAELdjBIxZoT0ivfzFSLeHhJeXO4TQ8eKgILdSC6o6Hww0+9l/hL6pjEYY/H9KGB8Clg==", "980e09e8-c1ff-4aac-81b3-29d4c0c60d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2c7486-44e4-4e79-b06e-1371dd474f63", "AQAAAAEAACcQAAAAEMpQVqFiIb1RNIV8jI8cSAIJf3iAFxRYmOn3lIXJm/UQ/akT1o/WRvOx+mmMWXTA7w==", "34b15d94-7832-485a-bf66-7b16ecfccefa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b2aa7a-6086-4028-a285-6cdd5267f211", "AQAAAAEAACcQAAAAEEoQ3dyCqG8mpYovuz7t9SlmtbqWyWVwTw+qD89DtVsXgiIdwG5Pwb8J6yMKUXrouw==", "0ad30d8d-d211-4cad-9caf-d7043a8ad060" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bdb1ab7-499b-4d92-8ab9-14c59e42ab54", "AQAAAAEAACcQAAAAEF+nq1ldOEs1inTay/QsruaOOxOmsbWkq104nNn/pfT9Yd2OtJdCcbo35KxGeJPTqw==", "16ba13fc-723e-42f0-b21e-cdd72bc56059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562d7689-7259-4014-9f73-5950ce99449d", "AQAAAAEAACcQAAAAEHOCXHzchKl0EIS4CqBs5I9m+7gA6ZZTjQo55K1Q5uZ4wuXOfJr8FRBzZcGEVrMZxQ==", "1ffcaf72-d42f-45c2-8425-d7f0c258b3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "515c1110-ad27-4bf5-95a9-6aaa9629c28c", "AQAAAAEAACcQAAAAEKhDVnKgJCBd//5H/18mIKGSQeu5mVpMlPJvSZv+/vQzEE+D5Z/JPrg+iU2u8P/TBg==", "92862374-0799-4e73-a042-1c9e5f432cc3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63dfd482-25ca-4e54-a0d9-fb3b62148cc7", 0, null, null, null, "49814e48-e0df-494b-bc34-071f4a0d4c3f", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEFRp7bMJDFc7br6EeVgXUrQg9e7qtnfcXaDsVkhiCUdVWekTK3bYFE6H/u0Pvgv9HQ==", null, null, null, false, "1", "0001113", "68eb2f32-6b61-420f-821a-ee3d5ea7fd62", null, false, "mishka@gmail.com" },
                    { "84412f18-3b47-445b-b6cb-6d6bb88860c8", 0, null, null, null, "abde1780-a8a9-40aa-8a66-b3aee1b4a2ad", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEB7dwlv93D6Y7Q89LhCvXOhiy55JbbOLUgJ7hUsxyv2+A87yV+x3pSw/yzuj7NJ6yQ==", null, null, null, false, "1", "0001112", "90821344-d8f9-4c54-97c1-dc9b81e05aa2", null, false, "anushie@gmail.com" }
                });
        }
    }
}
