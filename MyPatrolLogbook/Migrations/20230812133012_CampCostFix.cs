using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class CampCostFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9761a887-71ad-4a7d-8972-ac86ffcb593d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d13c066e-e78d-4e65-a171-19588b47e5e4");

            migrationBuilder.AlterColumn<int>(
                name: "CampCost",
                table: "Camps",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "59c1ccbc-93b0-46b9-b8fd-5821a9cfc013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "810cba5d-8108-49cc-9e48-7dd401435d70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a0fce821-66b9-42b9-840c-5b511e2420f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a2094b46-43f6-4c5a-9390-22ffce7e40df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15bb508e-7a1f-4c34-b67d-8859446014c8", "AQAAAAEAACcQAAAAEAwlhERI7KIKg/a8vQvmGBC9c8ty3Bwl9lr8U5a/MWEwfenQB425RKvVhU9oyuSEww==", "762c77d2-740c-427e-827c-4ea7e19a8a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "459494d4-909f-4c72-9a7b-39ecc3d61821", "AQAAAAEAACcQAAAAEOyXkjRG77cFCWCzaYIuTFI7mr4DUsh82xLQrFcUqRVJEq6mQ+8IpUHubtRDbHh76A==", "c5f83190-a78f-4e57-ba08-63052746f217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d0519a-c0f8-46d5-8e06-2a6cad2234f5", "AQAAAAEAACcQAAAAEEmQbNkDnyGkNAy3wWenlVILFsC/Ot3HBWQfTfwX66CZAD5rED5FBz9qag4gCjGThg==", "e021bca2-6978-49fe-9198-7fb6284fc3db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "556661db-31d7-466c-9a71-88336e059991", "AQAAAAEAACcQAAAAEBvxixwl0JjIql12ls0ZTwb27o/k8QQxJhC/JYroruDUkLdsCshVebDKNtA/LgwG/g==", "4c71afe3-bf62-45be-b48c-8b558571e2c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2067e43-b5e2-4db1-9ace-b8aed63ff2bb", "AQAAAAEAACcQAAAAED542AdX5if7mtGApkTHk2TRZi899xnQDtgs3AFRHmCnJZri+CNi4OsV+mFAtCL+mg==", "66da3a98-13df-4623-9a3a-e7008ebc491d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e665d0c-633d-4ba0-a831-536890f1d3db", "AQAAAAEAACcQAAAAEEUNixiMHAS9oxHfkgsEApW2b90+25j1DzHLSktUjCsSiT1NzWyLZxr0h0bSwd5rjA==", "92443e63-96bc-4d85-96de-ff614855dd06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b527fcd-1d9a-4a26-9bad-9968c3066516", "AQAAAAEAACcQAAAAEFXLGcE6pTs9CKlDqjLfrhfISTnP/FADkNh1T2D689c2Qkt/Z5SlZozcxtB1UT2Z7w==", "fa4e08bd-1aea-4350-8784-bbebe5a38d45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "935f3b7f-69e5-4542-83e0-3cf68fce3b20", "AQAAAAEAACcQAAAAEGv7x7FhTrwqUOJdy4djcdc274k8YfPe88SXVXyx/5xL+2K/CZYulo9ejryuvpgB4w==", "ae85dd05-2348-4531-b633-04d091d96fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0dcc7c4-64db-49d6-bede-db12eb65faf6", "AQAAAAEAACcQAAAAECelS84/3euPNnuifus/LWQa8Ztk8n+jbck/mcXXkpEa/kAHzIrcniOloiViNkCPMw==", "f4e49802-862d-4129-ba7e-52735256e4a5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0fb2971c-915a-41f6-bc12-c252c117f104", 0, null, null, "58c331df-296f-4d52-a792-15939068acf6", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAnrdu+vVZ0jFAxQfF4SM8LE9uecpvjKSQ6/R/hd60hgdrlPUYkMI+RwbBnRWp731A==", null, null, null, false, "1", "04ff9958-1058-45a2-9ed3-855e9651d27f", null, false, "anushie@gmail.com" },
                    { "5bb079f1-260e-4342-bc18-edd9f95f956e", 0, null, null, "802721cc-371f-436f-84b4-09e65cb98ebd", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEJM2MtwrMmObFUdNRDqhwGVSpUDHDQmu37AxrT8EJYVkfMi7ragjMVHpP/c+eMfjXQ==", null, null, null, false, "1", "ad649b43-b0b6-4250-be60-56d5bbbcf61c", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb2971c-915a-41f6-bc12-c252c117f104");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb079f1-260e-4342-bc18-edd9f95f956e");

            migrationBuilder.AlterColumn<string>(
                name: "CampCost",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d144c94-7a38-463b-b0d6-a538da9553dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "90757e69-26b3-423d-a71f-e79450231e8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ba8ca5eb-85ec-4f41-91e1-fe0697681013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7875a5db-93b8-4ec6-b86e-358d5af77b3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a02a8784-a472-4c4b-a1de-b031a1e8890d", "AQAAAAEAACcQAAAAEGVEoZ1iSwEe3zt70xzp/4n30jWY/heiM3w55n484cY8gwshiYppG8s1vnWhZsqqCw==", "984f9356-b4f9-4813-abaa-6cd559b1c944" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "117ea56e-f380-4dd5-9da8-f4a828a2d9ce", "AQAAAAEAACcQAAAAEAhwn4uDtI0Xh/RvHXu5BTjRcmajDS0T2cXvUxFQzANVjQEE2B4I3/qP9O0mFx1Oeg==", "4cb8620e-a9c0-4eed-92ce-6fa41940419e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40d45d8c-47ed-4abf-b24d-8a9ef9dfca19", "AQAAAAEAACcQAAAAEFtJ0cwz6Qzuw33/rg5cL+X2AU5L9sLgFuR/0JWtHEg6427yG2FJVz2CzWYiruDwWw==", "455ecb9f-0984-4b23-9c00-001564a75b74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99851355-de14-4925-9b34-9b2630e48b59", "AQAAAAEAACcQAAAAEKEtTrXk64uMH6ZyeZTNPmkA2C5ZFd6J5GCVZ4bBXLqqrL1nNJlupiBbvHk0Yw0p9g==", "0bf9c91d-5ebc-4847-a46f-c715be71ec99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67426cf9-8fd4-4b14-8b64-7a17b426db80", "AQAAAAEAACcQAAAAEGyxRiIAHxKNDZ1ZV3VfAPBOKmR+OOWqJ0iHgsuDcfegZ8f6nRrAq3bRc5hYmbk0Jg==", "82f35bfb-a970-4ed9-9e0e-469d85c21afc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea8a32a-e42c-4492-8b20-61fe12d99175", "AQAAAAEAACcQAAAAEFn2yi5rn/q6qqRkF0QkgN1kX0vEK7/UXNOsEl3GIhfghRRh3L2M4gOMbcZsojQ1rg==", "847bc06a-c7a4-4d96-99d3-747f6e08876a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7f7c0a-0455-4fd9-86d9-54dc9b111370", "AQAAAAEAACcQAAAAEGK/T0z8BS/MFrNksUk4iDZjZJ1FJMo4d4ROXOI0ADKWa5VbvVqjAVVs+41W+SNmVg==", "8ebeffe6-8bbb-4511-86ea-d6bdff96110b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae652689-2796-448b-925c-28e1c7797229", "AQAAAAEAACcQAAAAEKsOwTjl/b/2RpI+5/GvoTo8R8GvD35n7xzw/UMI+5vS92JIxWGFzIuKwpmeoriKWg==", "30ae87a7-ebfd-4aef-b535-1d12750474d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6856ca6c-54a2-43a8-98a3-bb57f9ef5bb5", "AQAAAAEAACcQAAAAENi88ILStjM/o7EdC8+RyLCsSjyFAM+KyEzWcK7mIEYRyQDPEgp1ZlpDn4EJKtij7w==", "da8c22ad-f557-4238-85eb-4804486ceac1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9761a887-71ad-4a7d-8972-ac86ffcb593d", 0, null, null, "8406a483-45da-4cef-8c4f-7992680e5a15", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAoB2fjpI61xh2kTzGkg2uz2HPR5RxG6yAJ5zPp9HflHczKWLz57K13QOqxXPy8mLw==", null, null, null, false, "1", "24eb2790-b1d0-4d79-af25-8d5f945a9872", null, false, "anushie@gmail.com" },
                    { "d13c066e-e78d-4e65-a171-19588b47e5e4", 0, null, null, "ba9ce782-87e5-4540-a3b0-3c3f56bea8cf", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHncg/BJyS33+vnoS30xtFlnYMk2sA2AAFduwa4YlLOiU5FSBQp1gRl3JzLsVJQYOg==", null, null, null, false, "1", "1478d36b-2470-44fc-a6fd-13a4c2beef5b", null, false, "mishka@gmail.com" }
                });
        }
    }
}
