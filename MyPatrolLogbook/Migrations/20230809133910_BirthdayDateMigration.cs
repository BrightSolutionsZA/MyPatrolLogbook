using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class BirthdayDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e44fab2-4e04-4e87-9b28-04b04023dbbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8f11fbc-8dcf-4a08-bcdc-c569ed4b5c07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "723019b7-61e3-4a26-aa3b-56681037197a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f0b748a1-a58c-4748-97a2-e9eac966590d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "45c9e6e4-d44e-49a1-8055-97c88e8a965a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ca5840b6-b6c6-4689-be2f-ccb9422ecfa5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "984055f2-330b-4f54-ae53-50cdad21a7cf", "AQAAAAEAACcQAAAAEA5DY+krACL76BiqX0q9wmLjA0z6lk7qVM5pL8r6jGiWZjzMqEmYWuCeZrHHiI6N8A==", "5033828e-a610-4784-becb-0aa8594fb15a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fcf927c-a48b-4e94-90c5-2f3fd7aad08f", "AQAAAAEAACcQAAAAEGx6tGBkSL6u203cZBddq8efuRdXAeTXnyajMej6zIMmtMjVGdL+XlinOuFg+TavlA==", "873075a6-51d4-456b-b1ef-7a44b315a37f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5d5539-5067-4c6d-9cee-e7fb3f597584", "AQAAAAEAACcQAAAAEJS4vKtC9rE/3wWqMg02x9NnRQNaXMHwQbgANGQs89HAepNEtR04+ZnJbTBJmVKf0g==", "5af31fa9-ebe7-4698-9990-a72974c66c53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8d2cf8-71a4-4e1c-8b36-343cbc4e1a0a", "AQAAAAEAACcQAAAAEGCW4fsV5gkxNbqAxW+3Wdl12GZC2pybx/E4zH+aMB2X42SyyQz58I2zSb5h6RV5Yw==", "3179bc0f-4307-4aea-a4b6-7600a2360755" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9059e1d-0394-4499-a02c-3d93d4341ba9", "AQAAAAEAACcQAAAAENCS/UqiLi/vrA7Mu12bPOqwp8PLXHs7jO8Ku042NcknFaF48wKzmeXA1v4U77lZZQ==", "98e35b85-60cb-4fcf-921c-79f23f997269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "340aa058-90c0-44ef-a447-562612dd6445", "AQAAAAEAACcQAAAAEK9GVLZEBuN4cVyxcBNVqM8RJzA77kjNyogywm6MpbUIe6qdI4ZbXoRmy8Cbj1Aiyg==", "385d54d4-eca9-4160-bc0f-385f42616a61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88e5cb2e-aab3-4433-b990-46027610375b", "AQAAAAEAACcQAAAAELF1Xxn/haqPivnquFR/ILw9YvtGVgYBrEMg6HxmE/Eu5CmVstIdVZH8ORYVDLmp4A==", "92967c66-65fc-4f42-a11a-8ea7c3ae9aaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e297565-8e11-40eb-9f5f-7e3d4ba2ac82", "AQAAAAEAACcQAAAAEDyOV+xi/DGZskzAKmE0UKlYTDgNsqRglV/zKt6vmaXiIMiIgmH4tL395VNeDpWh/g==", "18f97c3c-82e8-4a45-8960-f9f9b7a68f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6f95a55-0e0f-4d71-9a42-a45644811b2b", "AQAAAAEAACcQAAAAEBpElpVB5t9MTGb232y9ljwOjBpaR7qBz0Qc3gKICrQhqY8ddYzLAPNdM6NqGvzt7w==", "b0c2a33c-6031-4384-9608-185518ae5b3f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e229809-7311-447e-a2ee-a5b18c5fb12a", 0, null, null, "38f7954e-8249-4b0f-a21f-6730336f0fd2", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEIrFjCl+5sfHiZHi9fvCfMHnO5lg26FyVrJhJg63uL8GuxDpcdbTzfKiaUQKuEBpHA==", null, null, null, false, "1", "f726285e-efc1-4a92-89d3-b3b81fa808fc", null, false, "mishka@gmail.com" },
                    { "3e8bb124-a891-4c78-8342-6c7fb4c004d8", 0, null, null, "226db775-96e4-4382-a6e2-24afcae1074d", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEDvuHzu5esYRycCBTMEhCKTAltEe4/KTkrWCahwMHJ51DtZ/Wzn32EEw9xVK8ihwNw==", null, null, null, false, "1", "8e055b14-28c4-4978-8756-49aee1d8c6a7", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e229809-7311-447e-a2ee-a5b18c5fb12a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e8bb124-a891-4c78-8342-6c7fb4c004d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ee1e7342-bfe5-4c84-b350-f48b1668019c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7098fcea-76d6-41f7-a49d-cec6b6010eda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7c691419-e787-46bb-afe1-7b81b28fde9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1204d178-387e-45c1-8270-399d1352d914");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d999d290-4182-43d4-bc2f-3d59216cb76c", "AQAAAAEAACcQAAAAECaP45RaoHJLssJi0r5YBphDi1vCSmrzHSomdLuwpslqK0OyWeS8BYk33oCwSkPS7w==", "9b1a910e-daee-4f90-92d5-3f135bc18b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8127cfb3-ca01-41a9-80f3-eea1c1322012", "AQAAAAEAACcQAAAAEHWT356c6p1QqF/dsX09XXhbaHazvLLitRcNM3WPfvRC9OlVNt0Ljdd640klqg1WRQ==", "8dcfeb59-5a76-4cce-9d17-cb74fc6c1396" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9912da96-cf3c-4db0-9e00-44f66b15e814", "AQAAAAEAACcQAAAAEDTUdBNVPcp9XIN295K2YcIpEWF6V98haNQp8TkrFq8393XBnzbwBv2abK+0T5KJ8g==", "018be4c0-3a25-4e31-a79d-e3445bb5ccd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49757d2a-d784-4080-b815-5f0a03dde182", "AQAAAAEAACcQAAAAENmOOoEceAl7GR/quTgZWr4yV7CQXX9fiPFe+etAdNjEFq/ddMvpYO63oFXMtymibg==", "f3ec3f09-ee4a-4762-8bca-02013eec5c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59216d34-3294-4e80-b98a-31b9098666b2", "AQAAAAEAACcQAAAAEOCg2q/S0GXvSH/Hi2sQWRpQsfFje93QfkEeZeU5Ptep5sKOKE0pOu7o4Z7MhtXbXQ==", "4c6902eb-fde9-4d2d-bc1b-f9a686a1a9e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e5b5297-b599-49c8-9a57-4142f0bf1413", "AQAAAAEAACcQAAAAEA6CLMccITdC2NCIxqoXI7HydSkKm17ozwQIo8bwXBC9g0tNC1oE7dy6OWXii5zNMA==", "ffa49412-584a-42f9-be48-05aa1beefdcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23e51ce4-0e65-4641-9b0b-be4e18c4669f", "AQAAAAEAACcQAAAAEFXepCQAdEk4bPm5qNeVCTq83x/nirSy4C96B3AuzHUq1XnalMRtM6qkxyzJTNo5fg==", "65c4c67c-f648-4eb5-bf2e-6071e2a3a157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12472c2a-37bf-4f66-bfdc-7e5905cd6af7", "AQAAAAEAACcQAAAAEC6yPcaUAfFIhOd475RRNha5/52/J2bOkmQxGKHYoqQ5unt9W71b6SbExvHKhTojhw==", "b6f35cb5-48ea-46f2-a150-586bdf9b85a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aebcb9cc-e9f2-4eae-9141-18ae8f0dc0fa", "AQAAAAEAACcQAAAAEO1x65olSe6vaf8ZNJJBbFjN+XQED2iHe536ooYG7AnPMBFFj7RCWJU4l8trmMVPDg==", "3c2f138e-ea71-40bc-a54c-f6774e14230f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e44fab2-4e04-4e87-9b28-04b04023dbbb", 0, null, null, "ee7a6a6d-6f49-4dc2-93f1-4ebc7974d4b8", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEERMD47SIqbR24VvUK00t85YsOPJTqzviOVg4hrzvukh4/PpUBSKCAj/6SUeMffLSQ==", null, null, null, false, "1", "0f3ea7d1-61f9-414f-b1d8-35f31cfcf6dc", null, false, "anushie@gmail.com" },
                    { "c8f11fbc-8dcf-4a08-bcdc-c569ed4b5c07", 0, null, null, "f68e31b8-97a8-4607-a310-43e5429f6cd1", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEPMd7OId56RH1nYswjKozipnSFqXpfloWaplSxbT8kade7mvs9aX2Yo1hMq2LQWicg==", null, null, null, false, "1", "ef5c76a8-8df7-4590-a8d3-5f4ae4b77593", null, false, "mishka@gmail.com" }
                });
        }
    }
}
