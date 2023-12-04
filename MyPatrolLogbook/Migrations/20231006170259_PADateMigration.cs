using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PADateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abf2b42c-db75-41d0-b411-24638ff6cc39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc8c8a04-cb59-448b-95f4-7426f044c881");

            migrationBuilder.AddColumn<string>(
                name: "EndDateTimeStr",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDateTimeStr",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63dfd482-25ca-4e54-a0d9-fb3b62148cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84412f18-3b47-445b-b6cb-6d6bb88860c8");

            migrationBuilder.DropColumn(
                name: "EndDateTimeStr",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StartDateTimeStr",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d9a357a0-685d-41c2-a079-675b0d7d1bd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "37a05ae8-53ea-48bb-af84-a4ec74cd5267");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "80b9bcf8-fcd0-4c99-bced-c8519f16ed2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d9c4a79f-9214-40bd-8bbc-59da9f0bf003");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdec5d2e-4a0a-4bb5-9e30-a0b1952667f5", "AQAAAAEAACcQAAAAEC+H5ueVgnlZ5RLsCI+lZjnyHwLC3WloUhj1b+2fb3uttOd3lt2cOBkx0yK5rtWdHw==", "9c27bff5-9759-41ae-b956-a190e71f095d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a50dc6a-1b5b-4855-b9a8-21c0a295dfd5", "AQAAAAEAACcQAAAAEByI5gDxVbWY7zq889dmvyfDDVmZcmMm57YfQj+0R107hb1n0ZYrc6rp7zGB2yKWgA==", "446ba3ab-900f-4e76-be30-f7740b99dd5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2e3bf4f-bc1e-48d5-9af5-94cc1a21bcb8", "AQAAAAEAACcQAAAAENmGmnDTHPwcmf19s/G1CyxCGdIAndbAXoFnd1KJVCDa2XzwK8myRVuDsfWvvkrevw==", "ce20a3de-41bb-495b-ada9-668f42bd68cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897711f0-cea3-4ccd-a235-3e2b3c5bac99", "AQAAAAEAACcQAAAAEHuvoEbJwW3/cXLdndzviVOq2p7+0ie+womiW3i576vCOZx2tR8lFRESkBDnvZ3lgA==", "bfa772df-1d73-401e-906a-d2c1d522dff7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a29a7e5b-8fd8-455d-87d4-49dd25238b65", "AQAAAAEAACcQAAAAEF3Cb/YmD3FXCeMGQRgwwAtPqW5ueZOZRXLcoK+U6/q6Q8VRL8LU9dEB5Md5+lwQzg==", "55b9b7d1-558b-4fcd-a7c1-677a8b55d98c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd62c420-51d0-4a46-8016-cb5c974a3724", "AQAAAAEAACcQAAAAEEBD0I/LkczXIR8kwKeGTRbfhBr0EnNd4CS/v2Gyyv52OtZMDQ30W8qqFFe0/STCEw==", "0732208c-ba2a-437b-a54a-ba449d34c5fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec0e37e4-22d4-423d-82d3-0e84cddae1a3", "AQAAAAEAACcQAAAAEFbeBS/VJjfe98MqH63rhIxiaRVPvkjd7+MTqGETMsjnCv2aQZEeLgt5EQIO1hT1tA==", "f620005f-67c7-487e-9ab5-4bb526d81b74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063fe9ff-c421-437f-8628-6197c7d901eb", "AQAAAAEAACcQAAAAEFVLIrPwr1T3RGgtm2ohQSeVqE6PP/9AAup7/zqX2x3QnLwUrHYmjCA2LosZykesiw==", "5c838684-c755-4efb-9bbe-7b4efddc916e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7758e68c-9e6f-4055-8feb-3c185783867d", "AQAAAAEAACcQAAAAEJdoq4O44edZBZqc+kB9gyM0YwlcmEffPcboG3xbgLhYVQUSnOEr9xQ3dHQaTJThKg==", "41db6f71-8ff9-439f-a3f5-5154e7e2995c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "abf2b42c-db75-41d0-b411-24638ff6cc39", 0, null, null, null, "e640cf34-1058-4cce-a4b3-346fe8a896b6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEGbm20ze5/sWFtHd8JfiE0zq76YphEazgY8GJIe9Gye5LiJrdcf0mJgWBU2mQc4uxw==", null, null, null, false, "1", "0001113", "b47f13d3-6809-4576-995d-57c233c94e51", null, false, "mishka@gmail.com" },
                    { "cc8c8a04-cb59-448b-95f4-7426f044c881", 0, null, null, null, "e6b90c84-11a8-43f8-9582-bc27906fa549", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEB07kxUK8V0rzc1VtHrkTdf9gdhk4SQ3ywijagc7WhV8bsO/lG07RTFQMKTGJ+WWzA==", null, null, null, false, "1", "0001112", "88c38c85-1eca-4d6b-9930-cb373577ea5a", null, false, "anushie@gmail.com" }
                });
        }
    }
}
