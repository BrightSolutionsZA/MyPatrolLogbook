using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CampValidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "1b6d7098-0190-4b77-bc0b-6bbe2276a757");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "86354ba9-3261-40ab-8a79-7476ffec6fdd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "00c3a2f3-899e-42b9-b090-cc0ba18cbe14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1f16c4fb-cbb7-461a-8f79-1c633d3a12e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38077bfe-23f4-4999-91a1-8ce3b263528a", "AQAAAAEAACcQAAAAEAA/8eUDTILN8fnNoC/B6pEdT++cP7DbDdm2AfI/FLq0J9Rju14SY242bvEBk7+M1A==", "78267c7a-f565-41e0-8260-4e750f6b26ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b793747-70ba-4c3d-949d-f05fc0e36a87", "AQAAAAEAACcQAAAAEHroCWEOP1kU9Ws48hKjC+SIIjVULmIGyOwHvppBGfBu1iSS+Eltgof6Fk5C0Zsjew==", "e5f6e557-7184-46fc-9f5d-c6a378bfe876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6baae676-0d72-475f-8eb7-ad495bf9d3d8", "AQAAAAEAACcQAAAAEIiFsziQCo2qCH6Nvga4F18Q4/3sU6koY86AVE7q+dxBqqoewZ9T5P8Wq1Dun7Bkug==", "a990eba2-3b08-41ea-af27-857721b13325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6872b87-96eb-4186-b3b2-88b70b94dc9e", "AQAAAAEAACcQAAAAEO3KfQHFegN0IxE88gmAu0C7yb87a0BsMH06C9iI2+b/x1/8r5JFJ0X0gTb3VkrS3w==", "521e62df-da2c-41b5-9237-388f111787c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a4eeb54-7606-4d7a-a1a5-55d82481a892", "AQAAAAEAACcQAAAAEAEtsiO7unptw98RqWtyfgxOZ6lQbsjsPoUju3h673AtL9R4zO+mq/RU5AuBDWyhlA==", "f53b454e-e842-4381-bfde-2733b1d43ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd03807-a3af-4d14-aea6-c5aacd26d087", "AQAAAAEAACcQAAAAEIxATLHIQcF9224CR7XJ8AX9yWzoMZAzEI7Y6UE0Grvgq7Oknp3pj8e/8xikdfumIQ==", "4856c7cc-b165-4fdf-b13a-b8ca309a40b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a8052ea-4542-4461-9ac8-0785ab1aa4b5", "AQAAAAEAACcQAAAAEEMm0Lpq03JC5kMpU+juac7uRLxixFgYr+/hezfjjN8qmkwBiKjDbOEVjUyCX+Ukhw==", "85363aa8-4c90-4888-aa14-13f9b4855a47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38b19ca0-3914-408c-856a-eca811781730", "AQAAAAEAACcQAAAAELqjMV+vO2lRvjVUG7bV3zm0PRBOKxpf7F0M3h1eEjpX83l8KwIbU8IinluhaY7mcQ==", "fb107e68-a400-4a6b-8eb9-60359d3978d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa7de23b-9442-403b-bdd9-9a329874ac6b", "AQAAAAEAACcQAAAAEBqA4P5wxlbu78wMVI+0cLxfnrhl8yYdsQPWGdx59RP12bd8eGwuRAz2B/vvnycZAQ==", "0ae3dd2b-eae4-47ee-8f8c-4cfb488648b8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a82eced-182d-45dc-b56d-cb87e7e12453", 0, null, null, null, "8fb10457-1148-4937-adf3-a128678417c0", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEDRcMeiw803ZVkxkeiQzjLqd8Vyg9Pc/E/YZ3srVn3KXHHiqfaTIiEnFp7v+AUif5Q==", null, null, null, false, "1", "0001113", "d977aeb4-7fd0-478c-bc97-59e6687d292d", null, false, "mishka@gmail.com" },
                    { "f39d8e34-a88e-4bf6-bc2a-f5aff745eaef", 0, null, null, null, "c7ac78a5-2447-40a3-9bf7-984827ec4d09", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKKRsdtwVhzRwpkQInmUQ5yswIN51nymsZ+N9jIMaD8aR0JvRQw1h56zg+Ga+3cbiA==", null, null, null, false, "1", "0001112", "526c628a-7b4a-4f03-b10a-35694a9bc500", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a82eced-182d-45dc-b56d-cb87e7e12453");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f39d8e34-a88e-4bf6-bc2a-f5aff745eaef");

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
    }
}
