using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class UpdatedAdminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eec2465-5f01-4042-8220-1f25ad70d561", "AQAAAAEAACcQAAAAEE5zo9RJ9qxtYwZVHrt/4iL8oHLY0tvFHZjUZZIFksB6YY40reA+CGiTGDq1fDNWlg==", "82124b5e-7622-42d7-9d96-e4816cc763f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4003c9f6-d4b2-4bda-a57b-c469a1568aca", "mpl.admin.fs@gmail.com", "AQAAAAEAACcQAAAAEGVnz3fKZLny0i3wsoxGH4WWJ0XfOmvwe+gjdAg6aQREiFLVVsULeiHeZFDJIkAmUw==", "6f8767dd-fab4-46c9-a8e7-ff03ab32fee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d44e9e5-431a-48b1-8ab0-c9872c2d6dee", "mpl.admin.gp@gmail.com", "AQAAAAEAACcQAAAAEGqF6VKR3RIVPDdoHqy6i+YqI/kM0NejkbKEnzZm9qgAYN1SyREscSLriF7OqwCRyg==", "737a6334-68b3-48a4-925a-038e8789c952" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e2e347-23ca-413f-8dc8-9848cfe0b81a", "mpl.admin.kzn@gmail.com", "AQAAAAEAACcQAAAAEH770rtrBjSqbiKdRKXMPnCZxHv5g0zl94FxCw+DcO4M2QdoM2IJWjNP6A/a/7XCcg==", "f51684af-ba58-4f8e-ae93-05039f8d1d38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc733308-d929-4c52-a1b5-1c58ee9e2e74", "mpl.admin.lp@gmail.com", "AQAAAAEAACcQAAAAEN9c8y6V97ITcYWXlMj3wRtlVCZ8s4N/2QCtwByhlCb5uV+DiJtmxxblpkhjarM8uw==", "dd5fadcc-425b-4419-96fc-c1528af23757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b086d6d7-2c59-4b41-ad84-28e77606f5ba", "AQAAAAEAACcQAAAAENyqyu8QbcA0bjubWkDbMO/7yxJk4dpgR3YsTKaWfK3uxxFITR5D61tF71/NOkBFCA==", "ce9fbae8-c3d5-404c-ad2c-e6f6d052f903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f122ee-597c-4314-8a18-a2823347a607", "AQAAAAEAACcQAAAAELvMz5kyFMf9Vca2njKs7Z91ovT5435VupDays+D6XhuPOhjHhnGhUtHfdXQPgmS9Q==", "2baf2eaf-065e-481d-af89-99d96e29941a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ff16c6-c3c9-412d-92ec-496af37cb7df", "mpl.admin.nw@gmail.com", "AQAAAAEAACcQAAAAED49nKFe6JluoZHLrrGEZEXJ5vZSYSnHBdsKBkiyi5ri6bEdwtc/VEoaXtczaZ8+KQ==", "f1e0172f-8437-4e19-9f44-84ef6a4391fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "473a0abd-bcbd-4ae3-b678-3667b322ed3f", "mpl.admin.wc@gmail.com", "AQAAAAEAACcQAAAAEKuqiqldoiOA82k//cJajwi9Cy0R35YsceMsm+GplNKaxwBNF4U0DLkgHc4KBhLBPw==", "7497c471-694a-4020-9ee5-7a533ea52f97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b7d966c8-a871-463e-8513-c9e4f6d316bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8ccf848e-737c-46f8-a0c9-1acbb28cd117");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ee0d9523-6cb6-4f88-9080-f4a94e21c6d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "bdd767ca-ce0c-4f75-ad1e-04ae0fc3ea94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12fc1912-e62c-4448-a98c-fd2b6bda8ea1", "AQAAAAEAACcQAAAAEMqUke66ertzrcvL74QqwifnmWEDd2Mgwqfo2m9Y4Lv1LJrMzwrTlvxX5kSLS199KA==", "4a1053a4-9765-4372-9e36-0f40913721af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bbaecee-d6cd-4775-acef-6df29c806cdf", "mpl.admin.fs@gmail.com.com", "AQAAAAEAACcQAAAAEGhdftMmk+gaV3Tu2rAmXBSw5FtgAf3z15+4kZjTsG3JY03utWLmIHF93Ft6d25LuA==", "6a5b5041-1bd7-4950-85c6-c77df62a72af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ccbb670-7701-4426-b40f-e95477de8bd9", "mpl.admin.gp@gmail.com.com", "AQAAAAEAACcQAAAAEBfymxs7lQGQiViqJ3EQMpJH0nkPG50vMVGvfto9KjXLFQ9ZBZDNib6jhl7AnwNOnw==", "31a1bfcb-88b6-4e7b-8080-461b9c22fa52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12cc6d30-9c35-4312-974a-73454adb68fd", "mpl.admin.kzn@gmail.com.com", "AQAAAAEAACcQAAAAEE8pociryFH9uafmtwyMlFOxJHTy89QyncAhf33b8Mqq26u8xdGJnjScVMskSHOdcw==", "07a3d350-d1ef-4a60-84ad-f1791b061b7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34911286-f170-4750-bd7c-4a1174f93a9f", "mpl.admin.lp@gmail.com.com", "AQAAAAEAACcQAAAAEFX4XYJSLKiPJY6WNP/dtrPCtB6kHALURY2TRuAYOlL4FPUC9bXK19MrZPiDFJIppQ==", "39755b8d-ed73-47b4-8086-ae0fc571b236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94e5479c-5dda-4333-9423-5c13c43a6af1", "AQAAAAEAACcQAAAAEFClLDkR1LgOjbiQBWZsX9kvG1XE267rswXY3LYBmtPPxAGVwl2cL+BDaxlmHVjbzA==", "f252a343-525b-4457-855c-385ea074a40e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44bb3b75-8292-44a2-90e9-42442376af86", "AQAAAAEAACcQAAAAEEj2HWTIjuEplTjM7N7VI1l2bBTZVY23BGiFVNLQw2s4G08DQQeOngq0eEYLtlYanw==", "45fc0025-cb7c-4833-9fd4-1419b0afc428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf44f18-b42e-46e5-8e41-3d3464d925bf", "mpl.admin.nw@gmail.com.com", "AQAAAAEAACcQAAAAELQTKayYuZZwkrEU+lfotr7AfUdkOj5WGV4Awm0opEPSHLYQVbDz2hw+EB61Bj4d4w==", "508137ca-2269-4d51-9295-b75bcfa23fa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92257970-a4a9-47fc-8b0b-d62f5a5b7515", "mpl.admin.wc@gmail.com.com", "AQAAAAEAACcQAAAAEIGHLQ+vlFH/LwRyAAd4RSOIXm9qOgU2u4lx5R2VlGoyHG93ibdebTEJ3wP5yOGXqA==", "caa03eae-7310-4521-9484-ad9cd73c2056" });
        }
    }
}
