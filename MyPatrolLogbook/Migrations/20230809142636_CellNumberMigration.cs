using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CellNumberMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e229809-7311-447e-a2ee-a5b18c5fb12a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e8bb124-a891-4c78-8342-6c7fb4c004d8");

            migrationBuilder.AlterColumn<int>(
                name: "CellNumber",
                table: "AspNetUsers",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e860c216-e8be-4734-878a-8d2c28573f43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bfaa4220-2e81-4794-a677-a23f0d4ceb78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ea89d141-7609-4618-8a65-eef8f975b711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "b8c9eee3-9c6b-4ec4-867d-19b0885f6596");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0a5246-fe59-444c-a1d6-265eea84b129", "AQAAAAEAACcQAAAAEL5jPaQHY7+B8f/n0AdZRZIej/IYvWUJ6jNuKQs3tqqxCYDCYNMWv3DmXUr7vElXGw==", "55841eb1-3d04-43aa-8fb2-b2929d9d096f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02d9969-f564-4c92-8fbb-973062f82aa9", "AQAAAAEAACcQAAAAEKfwkQbYInQBYZL2J9tbwChNGAACoubWw9knAmEZaxfNuNY5fJ4N2H3ix7KcGB9Syg==", "494579cd-83f6-440b-85ca-b00fc7aea356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a2010f-4998-4ac1-83b9-a286d4fd8110", "AQAAAAEAACcQAAAAEFrbGxLK8+8iwub8IhqIqBYOlFczS92uvz5VRJA9ZUaTpS8BY8PNcfROyicXojLYAw==", "c7a42c14-7c49-408f-8ae2-1cc96c009dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68c6d742-637d-4f6f-8243-8047728bad81", "AQAAAAEAACcQAAAAEKL57eUAFOsvUuD7JH139/DVOrvZA6VoML6JjIAThtp4/w/lN3NsaDH9ubI8wshslg==", "4dfc7473-3070-45c5-be3d-cc8cbdcdc6aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731a8f7f-e630-4ae7-8059-877e581a67c6", "AQAAAAEAACcQAAAAEN5gAMLtbGJ7Rg3dSnR9Okp5bkQVMKvcB/EE64YXVtiavFV1P4sUBmxzHf2+QNKK1Q==", "d683da29-b66c-40e0-9d77-5a0bc72c3059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "137c3d8c-7fdc-47a1-92a8-0fe23d50adae", "AQAAAAEAACcQAAAAEDWTNT3JPCo8R5VQxdd30X1uZM89ihXxOJICoNIAOfusMmj/5LF4iEaEe9ZDtGBKuQ==", "2bb1b780-d3f5-422d-80b1-5119585b7a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c397d43b-ce1a-4c9a-9c7a-2b8ff9740027", "AQAAAAEAACcQAAAAEH7c3HQkuJA0WPGP7GIZJ4dhlBMSNE4d6LHlBejZmFb4e0dV6zye+jpVQ09MDDiaqw==", "a7d2800b-e49e-49a2-a672-e2200739f214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb268df1-a556-4408-9b95-83bf4a0db2dc", "AQAAAAEAACcQAAAAEILqkeLs0q1dDBDAx+0BrbMGs4ONqULOv53mfi5GFhLYXJA2JKMjKwCVH+nPyJdKaw==", "c99dcca0-a418-4ff2-b977-de2895786203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb043da2-ced1-493f-ac87-c7696dfeccb2", "AQAAAAEAACcQAAAAEO1Db8jm+SNkNngC48anTlq4Ecg9aGqqxiCUyhd1H9b5iNcvgDA3ObDr4ZN8biKD1A==", "678af0a0-6567-4445-bbee-f1724899f28e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8009b65f-b084-4888-9fc2-57baf28e5aeb", 0, null, null, "36ed0e9f-8011-46be-8a52-663aea5e0fb3", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEBDuZ0BOADdt3LitBhlclgPr2G6WQE1B7kEM1sbxfRUv/5XkYifLVyibt6kVQidChg==", null, null, null, false, "1", "f823b96c-58c2-421e-8f44-2450e4715234", null, false, "mishka@gmail.com" },
                    { "df400462-49f3-4189-8df5-a2b2f81c2e97", 0, null, null, "f56fbfb4-b073-4a69-a6ce-585e733fd647", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECsWwTihDxkqGA6IsxCsGqQN3Gw6t4zNSOGjDV2sQ2P6gGBZbMbGRzHNdvpkgCX+Kw==", null, null, null, false, "1", "7604f382-dff4-46c3-a6af-00d6b6a3d98f", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8009b65f-b084-4888-9fc2-57baf28e5aeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df400462-49f3-4189-8df5-a2b2f81c2e97");

            migrationBuilder.AlterColumn<string>(
                name: "CellNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

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
    }
}
