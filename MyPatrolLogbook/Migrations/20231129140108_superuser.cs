using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class superuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "5bac02b2-ece6-4a27-b48e-9fb67b472c4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ec157a9a-f07d-40b4-b2a2-c56eab98b86b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f09d055f-8076-460d-a27c-d45adff0fb55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "79b6721a-1d58-49c1-a557-180dc17b0dbf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "92f7a269-2f05-4118-8d98-275a936de17d", "AQAAAAEAACcQAAAAEGwvB6i/1Mh+pVtti9ZE9JDMB3iJif4tmXD1m21xdheuk/DHs5l+B8eW13tsXvaFHQ==", "0", "d108f516-d6cc-4a01-ba0b-556b17c8607a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "015923a1-4a7e-40c8-9fe3-93f74680b975", "AQAAAAEAACcQAAAAEJJAl0PMUSnkmPlFRWq7M/YBwgCQ3YROnAo5KysmAIGgZfw0j48uq+Fx9aTSnBd0Pw==", "0", "6d27abda-73c4-4427-a30a-a1de280a73be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "a58b2ebb-94bb-44e0-8e36-2c5870561756", "AQAAAAEAACcQAAAAEBgL/u0Ru3pIwkP+9kuPjWtYJUhRPffM2kxZocJ1S/fgDNuwwcGl2zeyMsb0fZHe+Q==", "0", "c9baebdc-3316-4da4-a511-d5ae9bb090ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "ee328198-0384-4325-817b-8872a9849f68", "AQAAAAEAACcQAAAAELHtqN9Gr+hA8l/7yYdF9cCI12/oeCpe41dRDdvmztw74hSH8znRlwI9WSTEW1w1pg==", "0", "192b3264-b295-4cec-b288-b5f9b57b9ea9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "07d274cd-d41f-47dd-9c5c-01e71eb78eb3", "AQAAAAEAACcQAAAAEDR6MBPUMotGbcLFV2jQbu4SWTDyEZbn+iHUim/PMAkD+sobXJ6RTkbFo6Zo3zUtsg==", "0", "2cd36601-346d-413e-8f96-f32de35db18d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "62e31d19-05fa-47c6-a7ab-08a00f3dd4cb", "AQAAAAEAACcQAAAAEMLFn57rIV0Rqknw6Fan+v27z0/tzjhJlTx6+2DfxOa3zcOwqwJmAojfBJ21FnfCbQ==", "0", "859c51d9-3ac2-411f-8209-63212b7dd517" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "ec63c73d-5690-4e1d-acaf-95a3d4bb24d9", "AQAAAAEAACcQAAAAEH5xK0SEA+bMvSIl5U3vCXAioXuSmO9Q3QgyDFZbaH5hh4b7ZtLbbZAF0XB2xzLVVQ==", "0", "529f4c17-293d-4534-935c-6023fe4872c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "550e2439-28be-4586-a1f3-ce6020d34bc4", "AQAAAAEAACcQAAAAEHqC/i2LgyD9WQyZ6yK4I75yQedwhzZReWZ0NKktMllQDTIoHlDb6xhugQEor5H5iA==", "0", "a5ea71d1-add9-4474-94e9-aca5414c1760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "50d5b4ff-7037-494f-b457-c0d0d7251609", "AQAAAAEAACcQAAAAEH5z9LeT/A/CGhjc+oBUByHFKC8bVcdIWaZ6RY1nLvsHuf8f20AB74H+ghUvILiaVQ==", "0", "a458c12a-d550-424d-a8ae-6f1f3a91894c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "j10", 0, null, null, null, "8ad57ac7-3883-4222-aaf0-4e4decbfe451", null, "mpl.superuser@gmail.com", true, "SuperUser", null, null, null, false, false, "Admin", false, null, "MPL.SUPERUSER@GMAIL.COM", "MPL.SUPERUSER@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHOOKIrF18UL/7GkV4QwolYL45FkB5WynC/2wcvskp0fxPKLcigS+tSvu5bQt4iYbw==", null, null, null, false, "4", "0", "35e25363-b66e-43fb-a5d0-767dd4659d6b", null, false, "mpl.superuser@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "j10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "j10" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j10");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "38077bfe-23f4-4999-91a1-8ce3b263528a", "AQAAAAEAACcQAAAAEAA/8eUDTILN8fnNoC/B6pEdT++cP7DbDdm2AfI/FLq0J9Rju14SY242bvEBk7+M1A==", "0001111", "78267c7a-f565-41e0-8260-4e750f6b26ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "2b793747-70ba-4c3d-949d-f05fc0e36a87", "AQAAAAEAACcQAAAAEHroCWEOP1kU9Ws48hKjC+SIIjVULmIGyOwHvppBGfBu1iSS+Eltgof6Fk5C0Zsjew==", "0002222", "e5f6e557-7184-46fc-9f5d-c6a378bfe876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "6baae676-0d72-475f-8eb7-ad495bf9d3d8", "AQAAAAEAACcQAAAAEIiFsziQCo2qCH6Nvga4F18Q4/3sU6koY86AVE7q+dxBqqoewZ9T5P8Wq1Dun7Bkug==", "0003333", "a990eba2-3b08-41ea-af27-857721b13325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "b6872b87-96eb-4186-b3b2-88b70b94dc9e", "AQAAAAEAACcQAAAAEO3KfQHFegN0IxE88gmAu0C7yb87a0BsMH06C9iI2+b/x1/8r5JFJ0X0gTb3VkrS3w==", "0004444", "521e62df-da2c-41b5-9237-388f111787c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "6a4eeb54-7606-4d7a-a1a5-55d82481a892", "AQAAAAEAACcQAAAAEAEtsiO7unptw98RqWtyfgxOZ6lQbsjsPoUju3h673AtL9R4zO+mq/RU5AuBDWyhlA==", "0005555", "f53b454e-e842-4381-bfde-2733b1d43ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "4bd03807-a3af-4d14-aea6-c5aacd26d087", "AQAAAAEAACcQAAAAEIxATLHIQcF9224CR7XJ8AX9yWzoMZAzEI7Y6UE0Grvgq7Oknp3pj8e/8xikdfumIQ==", "0006666", "4856c7cc-b165-4fdf-b13a-b8ca309a40b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "0a8052ea-4542-4461-9ac8-0785ab1aa4b5", "AQAAAAEAACcQAAAAEEMm0Lpq03JC5kMpU+juac7uRLxixFgYr+/hezfjjN8qmkwBiKjDbOEVjUyCX+Ukhw==", "0007777", "85363aa8-4c90-4888-aa14-13f9b4855a47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "38b19ca0-3914-408c-856a-eca811781730", "AQAAAAEAACcQAAAAELqjMV+vO2lRvjVUG7bV3zm0PRBOKxpf7F0M3h1eEjpX83l8KwIbU8IinluhaY7mcQ==", "00088888", "fb107e68-a400-4a6b-8eb9-60359d3978d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SSAID", "SecurityStamp" },
                values: new object[] { "aa7de23b-9442-403b-bdd9-9a329874ac6b", "AQAAAAEAACcQAAAAEBqA4P5wxlbu78wMVI+0cLxfnrhl8yYdsQPWGdx59RP12bd8eGwuRAz2B/vvnycZAQ==", "0009999", "0ae3dd2b-eae4-47ee-8f8c-4cfb488648b8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BirthdayStr", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SSAID", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a82eced-182d-45dc-b56d-cb87e7e12453", 0, null, null, null, "8fb10457-1148-4937-adf3-a128678417c0", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEDRcMeiw803ZVkxkeiQzjLqd8Vyg9Pc/E/YZ3srVn3KXHHiqfaTIiEnFp7v+AUif5Q==", null, null, null, false, "1", "0001113", "d977aeb4-7fd0-478c-bc97-59e6687d292d", null, false, "mishka@gmail.com" },
                    { "f39d8e34-a88e-4bf6-bc2a-f5aff745eaef", 0, null, null, null, "c7ac78a5-2447-40a3-9bf7-984827ec4d09", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEKKRsdtwVhzRwpkQInmUQ5yswIN51nymsZ+N9jIMaD8aR0JvRQw1h56zg+Ga+3cbiA==", null, null, null, false, "1", "0001112", "526c628a-7b4a-4f03-b10a-35694a9bc500", null, false, "anushie@gmail.com" }
                });
        }
    }
}
