using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class UpdatedAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3bbbab3-8fd6-4d34-99cd-da92c587f482");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb9647ac-8ec4-496e-be84-57f2c9d895a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "49b3b6b9-03f1-4b33-9313-bf4d393f2ba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "83dc6290-396c-4942-ba99-8ddfe2b189dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "69e17cfd-4320-4ace-b640-b67199cb28d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "021f0768-5541-4bb2-a736-1f3afc8a02b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2030a2e-b626-4da0-bf50-ae29c520d750", "AQAAAAEAACcQAAAAEIls3xKhbmjOsRUM28gP12qFo2yk5EBspuCQZWkQLk+7D2LboSEiJ3TlKDWPjYCgig==", "bb9d1c6c-712b-41cf-90a0-87111f649d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9921f9-180f-4c74-b764-889d1c413ebd", "AQAAAAEAACcQAAAAEFqZhaV8nWgd/bTODu8MzlvVyP2sEOOpIv0gLWXTjpwd6nIxJWKUWbfTwSAro8aeqA==", "e8522256-9aff-4de4-98e2-b9ebe449956b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d70b3c2e-dbc0-4e10-a700-7bebacb3cafb", "AQAAAAEAACcQAAAAEHuVL3dHxNA0lyjD6DFHG9LmOROnUdlblVgvbSuRj3YGJNtGfjgaCVikb4C58gYUfA==", "0760c183-e3e1-4132-9ce7-b39d65bf3391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa852af8-e7ff-41c4-a93b-d3649c64f47b", "AQAAAAEAACcQAAAAECkqJh6ztuN0429k7qVbCMFsCeJj4g05MGqjfOknqByDZ71FvBwdE6KnAslhGzyltg==", "bef80af7-f881-4c6f-bb7a-a9aa2b16b6bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf12afb6-876e-4ef2-b3b4-f4fae17144c4", "AQAAAAEAACcQAAAAEACMezHl2/CjErMfE5q42RNzH04M7/a7OeWkjukKh1knkVWq07dUqedY2wcKsnK1ig==", "bfa99f98-2cd8-4f0c-9741-34beaf4cf421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db480083-b757-4ad1-a949-295795467217", "AQAAAAEAACcQAAAAEGFkTLpFT70jw03sSj9/IjqBspd4dURN6/ndRZY1aBKzoLhgPOftB1FRB+dIgv+H9w==", "92b95f66-91a1-46fa-8a3c-ff4e28aab8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94843f7-2279-4f90-b835-6ad9379ff3a9", "AQAAAAEAACcQAAAAEB3E6w1veCnBLrgf7zh0oh9zq/7cz6UjC8hMyuxxWA7wI3Iuomz2SpxoIpRz0oaIAw==", "9c662d8e-9b32-468d-9d28-c7287c695c87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2df74576-acd2-4d29-9cca-3e8aa06634b8", "AQAAAAEAACcQAAAAECUJy1CZUq33/mWs+z9+tBUwupc0QQdu0ESYsTMmhSIYB8gPLYsLYLumjMhcV0HqYg==", "868e106e-e335-4b71-8efc-347075f8dfcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c69f5595-8924-4256-9242-7a5cd7684d66", "AQAAAAEAACcQAAAAEMqWfPPw0jcdpTfWj34iLSogOFFhAwc7Yz6MmS4rGx/jU2fBS7Ed+lt6H38zrz0QXg==", "184b85a8-c33c-4282-ae3c-36aaabd01f75" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5fc0c851-b320-4848-b76f-c865d7471010", 0, null, null, "52c16190-7634-4c2e-acd2-838fa37989b6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAELlBwTrOnP4P65OQ+fUNKAtfjN4Jiw7FkNq74l7+lbcQQ3AZIDZF2l/oPN4GCSOVUQ==", null, null, null, false, "1", "6d3f2986-6127-423b-a85e-b2f9ddff5501", null, false, "mishka@gmail.com" },
                    { "79405132-38c7-4ef2-8de9-a431d1efbd3c", 0, null, null, "72b1c037-2cd7-449c-bdbd-4a8dd20ea8f9", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEF+wu5xD7/y7DfJb+6d8Vo0y3ksrMJQnq2sJrng0VzVFVTUVua4KrzfP5LtawylObA==", null, null, null, false, "1", "e3e26998-2243-4ed9-b993-de03905ed086", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fc0c851-b320-4848-b76f-c865d7471010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79405132-38c7-4ef2-8de9-a431d1efbd3c");

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
    }
}
