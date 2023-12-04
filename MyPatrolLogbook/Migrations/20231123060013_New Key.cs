using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class NewKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a02eb39-b70d-4547-926b-58342c00746e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b6a037c-2791-4d08-b998-86e612092b59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "886d6965-9edb-43b7-b2ac-647b376a8174");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "44ae5c34-e443-4130-b017-a0581865bb86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c72c4e9f-108f-482c-b3ad-428f354947af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "30342d0d-e773-451c-999f-2d48a3cbecbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f25bdf52-81f4-4040-9304-63bffaaef6ce", "AQAAAAEAACcQAAAAEDEwxokCx/O7jdxaDvIKKZ55nxs/DRQxISGjFvmbnaZR3Qf1acTzSxNc9puBwe1aYQ==", "e9f1a3bb-033f-4e1b-8679-55cd8ba303b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9918c57-1b5a-4147-941c-c4765116673c", "AQAAAAEAACcQAAAAEM9z9wEPuzz6LGs0jyOIljfxYZniUj0voKdOBIM7fe0yc8TiUszCfd0IwbxL0OPbnA==", "f993c8d6-8d49-4adc-946a-7761bbb24bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bda3a37-0781-4a9e-b8df-43f980638825", "AQAAAAEAACcQAAAAENICQXQn8ESFqRjvDWRKKGgztFOqn7HGS3NJec0FF65+RF3KE9hnZbmkY7sEQ0LkXQ==", "255bb7e2-ff3c-40d5-a20e-5ce3df29858d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "383c8153-7d4d-4628-b5fd-53e2b59f08c2", "AQAAAAEAACcQAAAAEO4/EuG/Q+TTGYfTFb0p9N8rN0+A4SygZkoiMcgiL0NiuBXwjS68fNf8rIfflIHEyg==", "c377977d-8275-4eb6-b2df-fa7846fc0f6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e79ca8-0761-4052-bd73-7eab05aec5fd", "AQAAAAEAACcQAAAAEKulaeNfD31cVxQfzQKisYouNS5c0OLTLwJDw2tcsQLIdOrn9e3Hpzs9ejYqTHKKjg==", "7d64e551-4fa2-4542-993d-4a0557c7f073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c4c7c76-cf28-48e5-9f7c-f1c01f98350d", "AQAAAAEAACcQAAAAEPoAlbNUR93N7nmrnT2oMyOwkTWtIrInP4v8fn7iN+A0LR2KcxZ/o5HdcvuOyx8pBg==", "cb0ab53c-277c-4758-9a8d-deb1fc56e954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4718f14-9cae-4539-aeea-afde6ebb61f7", "AQAAAAEAACcQAAAAEL5MBy9EsLN9/iipOAcE3TvTwaXOKj886zCE99qApeL9AwC/ZO76Nbvc2dpEpNnnbw==", "747d9784-c455-4567-bd9b-d668952488d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003b893c-a159-4c06-a0c6-b0947d5f12d4", "AQAAAAEAACcQAAAAEBbzRu1yT3zQRCHfwGJ8p+btcRA7BzDCrIWStQyM13VejkK6CxvY0asnv1vjoVWIYQ==", "2be8ee26-4528-4a0f-a579-f19c3aa5baf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a392c0dd-f05f-4452-8106-4391eac508e6", "AQAAAAEAACcQAAAAEPRy+qHyJSSCroO4r7sLCtit6lX6d3CwIX4/7KgMJ+8tZc6U//BkPZ5MPTBYqaSkTg==", "44d7641f-6039-4971-8038-db24ea0a28d5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4291391e-cfc1-4a35-956c-bae4c18dfa44", 0, null, null, null, "76c0df6e-8daa-4103-8dc4-f4414c4d50dc", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEBnPthThL484jPsluGAwg0BSwYCga4ZfN2ZHQBVj7cDYKVdOa09+ER9OjjDLuYB/ww==", null, null, null, false, "1", "0001113", "2ed383d2-130d-4a40-9228-b5fc2adc8b00", null, false, "mishka@gmail.com" },
                    { "82eaf23f-b7b0-453b-9e09-1132aa11f332", 0, null, null, null, "cedca502-1f60-45de-94e3-04a70a7c3741", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEMvHMYznlcmYN1A9ZS0U3TKES1QCxizsIZhWRA05BadbfmwUKLJ17Ynb2F3Fzk9RSg==", null, null, null, false, "1", "0001112", "2e5ed88e-1fd2-4dcc-862d-28d22a840812", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4291391e-cfc1-4a35-956c-bae4c18dfa44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82eaf23f-b7b0-453b-9e09-1132aa11f332");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "62aead84-6f4b-4efd-9c35-6572d7799cc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7c2078bc-4496-400c-97d8-4b0b5ff84d88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7733dfee-e3e2-43d8-9471-c0abd3bcd34b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7e888e00-b434-48d3-bb1d-21653936984e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39ae8e33-bc26-4c44-be44-07f86efa3130", "AQAAAAEAACcQAAAAEMXb36FmuYpRWqT5VHjxyLj9zO3ontz2/vfFRBqvHfkhYKmGi+aOqk+MwrA+Ie+0oQ==", "522a9612-83d6-4911-916b-f348f630522e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6c1aa7-9be0-47ec-aafc-4365c504a112", "AQAAAAEAACcQAAAAEDbxtTm65qTdK4a7/SnIA6oR8rYBWdb5JyFTSuzsOlkCh/ESximWRE7wVkot23/uPw==", "72cdfe5c-52b1-4a3c-8eeb-d41eecdadc0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e7c3dd2-b635-4c9f-af9d-f010ab03295c", "AQAAAAEAACcQAAAAEGGOWzeS1gbHZWL4zs/3jCsa72ELe15Ks5xeTGA12BbNgXOSzM3VFg+1Sc4m7magpA==", "5a5b8f83-4c96-4b07-8e71-c9f8c80e3157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec5951e-0b7f-42f6-9710-0acfecc1e681", "AQAAAAEAACcQAAAAEAQ/wYb/lTVVAJRjJhpWP28Fd9stcwU5gaRYH6YSqHuAtP6IG4zCgUTXLHswpYs7PQ==", "ae7a8dbf-2673-41a7-8945-c59db85843fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab97b87-2e75-41a9-afa5-524c2dd53b5c", "AQAAAAEAACcQAAAAED1CZaAhtR2epz0xO/lY0ty8tOs7rOXwpz1iEQj9HDJPRz6eqG0GVFc6eKGO2v6pwQ==", "d1883fbf-cf17-48ac-9f92-a54ce65fa9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee968a3-3b3e-41a3-b68b-ffbf72c83058", "AQAAAAEAACcQAAAAEAfCYTzaGs535jiLhVq+foj7gb30FqPuOqOGm5+M4Rie7U2wVnyvrljTB2K1DD5ttQ==", "ef3c072d-633f-4751-9a38-a6d0f596e36d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7c9257e-ad84-4cfd-b882-f80613697019", "AQAAAAEAACcQAAAAELRZOShgjH56vqYEE0d0hnlolBX/kYcX+T5D9jWGUInPRfNFSmx2hucaN1sensKpEw==", "0c560947-5611-4392-a77f-9f5c6583d585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22771c4a-a2c7-4ee4-b6f1-205db4fdf98a", "AQAAAAEAACcQAAAAENP8Pc1ta7anVzarZXDCxzY4Gebm72uAlX3rGB2YC5/cg7bMgJb0V8pzLXDWNRa0EQ==", "0d356972-a3c2-4aa0-b733-ad6fed9d87ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "238351e2-8498-4293-b088-ba1f56bf9587", "AQAAAAEAACcQAAAAECdGn8/+8QUutBoR+F08ZMJvlGcldh4stu3CCe2A90FGFh8R+pQ4bR+MVW4xjhjSig==", "84bf1733-a17b-4224-b539-d4f0f3c0db75" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6a02eb39-b70d-4547-926b-58342c00746e", 0, null, null, null, "72f4a4dd-901c-4005-aa1e-5745113a06a0", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEE2D8k8umZDOpdpizJhJ22UQ6Cef6d954U2yWMDy5Ov9ELSKfcnHlOuP8JlAP9InJA==", null, null, null, false, "1", "0001113", "6ee9f813-650d-4cdf-a1e2-7e54b4fbc965", null, false, "mishka@gmail.com" },
                    { "8b6a037c-2791-4d08-b998-86e612092b59", 0, null, null, null, "970ff464-0cd1-4286-8644-e53d8c82501e", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEA6o0W+07MLM4fSP5O2fVE2nTqOIMYQsPGOiSkr/8DFVv7tquzRIJlncnVlkHsS5iQ==", null, null, null, false, "1", "0001112", "3536d463-4c95-4f0d-bd54-5626ec807dc8", null, false, "anushie@gmail.com" }
                });
        }
    }
}
