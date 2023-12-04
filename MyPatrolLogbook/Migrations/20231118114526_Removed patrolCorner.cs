using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class RemovedpatrolCorner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a02eb39-b70d-4547-926b-58342c00746e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b6a037c-2791-4d08-b998-86e612092b59");

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
    }
}
