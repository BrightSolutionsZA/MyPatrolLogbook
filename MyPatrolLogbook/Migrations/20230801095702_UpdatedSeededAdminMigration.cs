using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class UpdatedSeededAdminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "163a89f6-9b64-4013-af3c-9ebe11941fe6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "27770042-8355-426a-b574-6238ef80d25e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f93aa59d-f30b-4620-9ffd-9c449dc3af0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "44cd3baf-cce7-4e02-b825-1996d80dae47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b3d7a7-c971-4c49-9482-085dc950de3e", "MPL.ADMIN.EC@GMAIL.COM", "MPL.ADMIN.EC@GMAIL.COM", "AQAAAAEAACcQAAAAEFu0zkiMEMTQb7z3fpJlcvo0fDqtur9/pFmkFaVc2yeNMQ4RvUjlY/wSf0ZpClMHtg==", "97e432d1-ccb9-460d-b526-6e0432bb8093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcc1a3e-ed81-4d20-9fc9-dd18433cbaff", "MPL.ADMIN.FS@GMAIL.COM", "MPL.ADMIN.FS@GMAIL.COM", "AQAAAAEAACcQAAAAEEFiWRmnq62ltXJk5AQOa4eWzJjDx0PcPOBNcT7wreES8huWFhiomjqwqkGkCpmAnQ==", "6a324393-c682-48d0-8cb4-9cc7fd215b49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad013de-1f67-4d5f-b79d-f8d927ec9ed0", "MPL.ADMIN.GP@GMAIL.COM", "MPL.ADMIN.GP@GMAIL.COM", "AQAAAAEAACcQAAAAEPjf3cIBhu4DioA+rv7BoSduREE+LhifCVea4VC6jCZX4nJWjt33jqCXumK5o1qLSg==", "5840f838-0a20-47cf-9022-61e227d3cd6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff7ce8b3-92a0-4f12-99b5-fdf6b84edd0c", "MPL.ADMIN.KZN@GMAIL.COM", "MPL.ADMIN.KZN@GMAIL.COM", "AQAAAAEAACcQAAAAEDH4CUGDM/r8BSVi1HGM7UbOPIHUyj4ivlGHesQU8B2yh0ugClDEkP3M3Q3wG/O8wA==", "79b4cc14-9a20-482b-97e3-a969f7d257bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8868357e-b578-447f-b431-92b24a640bd2", "MPL.ADMIN.LP@GMAIL.COM", "MPL.ADMIN.LP@GMAIL.COM", "AQAAAAEAACcQAAAAEMWapBJfbEFFvRBs7h8A3JTafTduK+sjFU255ASrNuEr4xrjtmwNeexkG7jNoLcfNA==", "f5cb9534-ddea-4b1c-885c-67589f91907a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d28526bc-cfa9-40e1-bcc9-9919c47ab973", "MPL.ADMIN.MP@GMAIL.COM", "MPL.ADMIN.MP@GMAIL.COM", "AQAAAAEAACcQAAAAEPU1RRPHnaGo1yGx+RnC4aUQPr+AJXbm21q2lparF/KZwuMspSOH47Asg1Feyd3lug==", "d43e18da-ae91-4654-8b76-e1e9b75090d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7afeb9-6e0e-4ed2-937c-422bc02cd534", "MPL.ADMIN.NC@GMAIL.COM", "MPL.ADMIN.NC@GMAIL.COM", "AQAAAAEAACcQAAAAEFpJ0w1yctwiRQSQxO+OhQ4lDnRT7QIwVPrfgXhgQ+riD6Xds4ndhK/bpMfnMzjjhA==", "a6315f13-9f73-4b7a-bdb2-c1eb58518dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb34853-0cc1-4c27-81eb-11628df0e65d", "MPL.ADMIN.NW@GMAIL.COM", "MPL.ADMIN.NW@GMAIL.COM", "AQAAAAEAACcQAAAAEHPfaeGskzwaDs/4PFgcKPSBcQBaIiGcH+3U6i6Mvspw/8/zNmZHb+LZ0Wv03bfnag==", "463bd40c-3aa3-4c73-8bfc-c780e52ddf39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9b1aec1-caca-46a4-99c0-a74c1a80ceec", "MPL.ADMIN.WC@GMAIL.COM", "MPL.ADMIN.WC@GMAIL.COM", "AQAAAAEAACcQAAAAEI07FniQnIw6Kq7ypldWQvtztqj+2mbkvcPmCuna7lEdvZrYujYY4HahRSHx/xlD2Q==", "6ad02062-4744-4c9e-a32c-d623a9de3d95" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9cd58875-87bd-47e0-92f6-5fdcaca4453f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "38c6fe12-34c9-4d32-8793-c96bb40cf7b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "00ef68a7-ef27-43e5-bc90-edcd26787c66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "40eef370-3513-405c-bde1-0bacfb719efa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eec2465-5f01-4042-8220-1f25ad70d561", null, null, "AQAAAAEAACcQAAAAEE5zo9RJ9qxtYwZVHrt/4iL8oHLY0tvFHZjUZZIFksB6YY40reA+CGiTGDq1fDNWlg==", "82124b5e-7622-42d7-9d96-e4816cc763f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4003c9f6-d4b2-4bda-a57b-c469a1568aca", null, null, "AQAAAAEAACcQAAAAEGVnz3fKZLny0i3wsoxGH4WWJ0XfOmvwe+gjdAg6aQREiFLVVsULeiHeZFDJIkAmUw==", "6f8767dd-fab4-46c9-a8e7-ff03ab32fee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d44e9e5-431a-48b1-8ab0-c9872c2d6dee", null, null, "AQAAAAEAACcQAAAAEGqF6VKR3RIVPDdoHqy6i+YqI/kM0NejkbKEnzZm9qgAYN1SyREscSLriF7OqwCRyg==", "737a6334-68b3-48a4-925a-038e8789c952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e2e347-23ca-413f-8dc8-9848cfe0b81a", null, null, "AQAAAAEAACcQAAAAEH770rtrBjSqbiKdRKXMPnCZxHv5g0zl94FxCw+DcO4M2QdoM2IJWjNP6A/a/7XCcg==", "f51684af-ba58-4f8e-ae93-05039f8d1d38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc733308-d929-4c52-a1b5-1c58ee9e2e74", null, null, "AQAAAAEAACcQAAAAEN9c8y6V97ITcYWXlMj3wRtlVCZ8s4N/2QCtwByhlCb5uV+DiJtmxxblpkhjarM8uw==", "dd5fadcc-425b-4419-96fc-c1528af23757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b086d6d7-2c59-4b41-ad84-28e77606f5ba", null, null, "AQAAAAEAACcQAAAAENyqyu8QbcA0bjubWkDbMO/7yxJk4dpgR3YsTKaWfK3uxxFITR5D61tF71/NOkBFCA==", "ce9fbae8-c3d5-404c-ad2c-e6f6d052f903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f122ee-597c-4314-8a18-a2823347a607", null, null, "AQAAAAEAACcQAAAAELvMz5kyFMf9Vca2njKs7Z91ovT5435VupDays+D6XhuPOhjHhnGhUtHfdXQPgmS9Q==", "2baf2eaf-065e-481d-af89-99d96e29941a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ff16c6-c3c9-412d-92ec-496af37cb7df", null, null, "AQAAAAEAACcQAAAAED49nKFe6JluoZHLrrGEZEXJ5vZSYSnHBdsKBkiyi5ri6bEdwtc/VEoaXtczaZ8+KQ==", "f1e0172f-8437-4e19-9f44-84ef6a4391fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "473a0abd-bcbd-4ae3-b678-3667b322ed3f", null, null, "AQAAAAEAACcQAAAAEKuqiqldoiOA82k//cJajwi9Cy0R35YsceMsm+GplNKaxwBNF4U0DLkgHc4KBhLBPw==", "7497c471-694a-4020-9ee5-7a533ea52f97" });
        }
    }
}
