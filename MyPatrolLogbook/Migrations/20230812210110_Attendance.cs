using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class Attendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb2971c-915a-41f6-bc12-c252c117f104");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb079f1-260e-4342-bc18-edd9f95f956e");

            migrationBuilder.DropColumn(
                name: "CampAttendance",
                table: "Camps");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "00f49803-fcd6-4cdf-bc49-74d319889132");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d5023900-d15e-4402-9f2c-294153748243");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "92f6284b-c52f-4234-a498-128a1bf44878");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "dd3d21bc-0ee2-42b7-a32a-90d38e769b41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7964c580-ca2e-495b-b073-a7b1257fa1fc", "AQAAAAEAACcQAAAAELf0Zh7mvZMGFmwIssLq1QludauowL5NoY30Rbh65HVgI6dM/1i580JczeKHMYrFYg==", "223a4c2f-0244-4012-b5e7-1da2a47770a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce5102a1-37df-43dd-aac2-360ba8a03cd9", "AQAAAAEAACcQAAAAEA7mMWYyg+koWiGVWtNG0IKA0XmnNFLun9md8vbsXMpG7Fi2YK+pjH76oe+16mdzQw==", "f016f1ed-a24b-46a8-91c4-c53843a37121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e573a765-1f95-40da-8099-6f0830330bc1", "AQAAAAEAACcQAAAAEAp/oxNamrMXskEpd7EtluYo6UtFEzHe2KsFVRJZGsnJeYR3+D5ObFfMlsjnKNP8fg==", "c427453b-8087-4370-bb81-57b12787bef6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9d5d1e4-3212-42a1-bd90-9a3a8ef465d3", "AQAAAAEAACcQAAAAEGEcoTCbKrXOXPykMEG6E6dqEB1GJkdCNcPwi88ruyhGJcZrukC0u9Rf/ZpMAfyltQ==", "a82f8be7-887d-4e5f-81e2-4ea307b6b6e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37a4f88a-e369-45c8-8aa9-b6779c0a683c", "AQAAAAEAACcQAAAAEHWKWBVOwTRx6bHfh6nFhlCka+q+qHf8k2rz+ilN1ygx4mVvxMmLowZyI+oi0Xt5jA==", "2f1f4746-25de-4b98-972d-f2a5ef07d4df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba91ace-1de5-42f9-a727-33df105988ee", "AQAAAAEAACcQAAAAED4Mm0IeEwbd5AptcY20eqneGSznfIxLN0YLkYxPFgD143vV5IGPplzaFH9ISoKxJw==", "67004a74-ad96-4a30-aff1-f4b503046cfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c23cb74-0428-4d89-8e01-bcc7f669bd36", "AQAAAAEAACcQAAAAEG9T5gy+lZLiLU0KIxN3H4JXmHWhqrWqsi3FApmOFl8QOd5ItFkXcF4HW2VGa1xy7Q==", "41587955-cfe5-4b43-9f7b-d281912152b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c682424-096f-4a59-b59c-f6f46bdaf9f4", "AQAAAAEAACcQAAAAEJ/7dBJmk+ArIb+nDA6PkNDF0slehDE3FBc8UVB8Y0ysU29961fr90+71dSSjybMNA==", "abaa7cbc-ed9e-4f3a-b409-690e001bf29f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8badae12-409f-4806-8eba-4bbbe8a10727", "AQAAAAEAACcQAAAAEM08rTDXnsPiLAQVBvpEU7dS6Us+n0IXBo5zL4SsSM3lnctdpxdshkcwkOnP704xRw==", "d4560644-5d3b-4f3d-8aca-3630a7e6fd0c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e3bbbab3-8fd6-4d34-99cd-da92c587f482", 0, null, null, "d0a90826-f923-43f0-b205-04e1f2832bc9", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHPhqv5vNxsc0gua5xNlcX4yN/eVIFAeHdlEHxfOHSX1hDfTZ9rdJIEDoQ84OJn0Uw==", null, null, null, false, "1", "f9676fda-3d6f-48ad-b900-fa09ce4e2527", null, false, "anushie@gmail.com" },
                    { "eb9647ac-8ec4-496e-be84-57f2c9d895a9", 0, null, null, "9425c395-5be0-4660-ae07-285b0d921331", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEHBBD4kt5SO1ITL+Xf0jT59L7cmZKLFW0wXN/4UfBS/wE7eWjmfdcC6bkvoHaPQa7Q==", null, null, null, false, "1", "07a1875c-920c-425b-90e3-ac6f4afbd3e7", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3bbbab3-8fd6-4d34-99cd-da92c587f482");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb9647ac-8ec4-496e-be84-57f2c9d895a9");

            migrationBuilder.AddColumn<string>(
                name: "CampAttendance",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
