using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class SeedingAdminRolesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "a1" },
                    { "2", "b2" },
                    { "2", "c3" },
                    { "2", "d4" },
                    { "2", "e5" },
                    { "2", "f6" },
                    { "2", "g7" },
                    { "2", "h8" },
                    { "2", "i9" }
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bbaecee-d6cd-4775-acef-6df29c806cdf", "AQAAAAEAACcQAAAAEGhdftMmk+gaV3Tu2rAmXBSw5FtgAf3z15+4kZjTsG3JY03utWLmIHF93Ft6d25LuA==", "6a5b5041-1bd7-4950-85c6-c77df62a72af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ccbb670-7701-4426-b40f-e95477de8bd9", "AQAAAAEAACcQAAAAEBfymxs7lQGQiViqJ3EQMpJH0nkPG50vMVGvfto9KjXLFQ9ZBZDNib6jhl7AnwNOnw==", "31a1bfcb-88b6-4e7b-8080-461b9c22fa52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12cc6d30-9c35-4312-974a-73454adb68fd", "AQAAAAEAACcQAAAAEE8pociryFH9uafmtwyMlFOxJHTy89QyncAhf33b8Mqq26u8xdGJnjScVMskSHOdcw==", "07a3d350-d1ef-4a60-84ad-f1791b061b7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34911286-f170-4750-bd7c-4a1174f93a9f", "AQAAAAEAACcQAAAAEFX4XYJSLKiPJY6WNP/dtrPCtB6kHALURY2TRuAYOlL4FPUC9bXK19MrZPiDFJIppQ==", "39755b8d-ed73-47b4-8086-ae0fc571b236" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf44f18-b42e-46e5-8e41-3d3464d925bf", "AQAAAAEAACcQAAAAELQTKayYuZZwkrEU+lfotr7AfUdkOj5WGV4Awm0opEPSHLYQVbDz2hw+EB61Bj4d4w==", "508137ca-2269-4d51-9295-b75bcfa23fa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92257970-a4a9-47fc-8b0b-d62f5a5b7515", "AQAAAAEAACcQAAAAEIGHLQ+vlFH/LwRyAAd4RSOIXm9qOgU2u4lx5R2VlGoyHG93ibdebTEJ3wP5yOGXqA==", "caa03eae-7310-4521-9484-ad9cd73c2056" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "g7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "h8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "i9" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "23c067b3-1dbb-4a85-ae45-1b245eef3b2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "45bb95eb-6036-44dc-a4b8-2e5c790bf3cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2bb6a16c-1695-4de0-82f5-53eb8cee8dd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "74785637-1ed5-497f-acfd-2bbc626a4c64");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3166b03-eab8-4cfe-942c-4017a337eccf", "AQAAAAEAACcQAAAAEJ/AV746Lt3VoosGvIkK8UAjlF0OmMtVETlRpTG+sdRvL2xQ0UwpTb8KnamG3g3q2A==", "a192a640-afb2-4a52-96a9-a157219d7b9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43b714c6-5f69-44e8-b43a-6551a90e6553", "AQAAAAEAACcQAAAAEC6alWN8zZDgYYEOORpEnosid5TeAZWSL5uXMiqFxwzPE5flDp+tgy4CN43ag1ZTLA==", "969bad92-3800-4689-bfa4-ad7cfcdfe012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a3ffc22-8159-41ee-b8f7-983fd153c183", "AQAAAAEAACcQAAAAEGDzH0ESev/xq+dARWrocmzZkc9Lh+V5UYidnCRi+IlcMCyGgpcMhy8yIwoJPOhvIA==", "e1085007-023d-497d-906c-db6a67e5ba81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f68e9952-3177-4c36-bfe6-6a9ce15bdc43", "AQAAAAEAACcQAAAAED45ECMuNgOYWB1uRfVYjcmAFSOhD0nDGvu37GMcs9EdJKh9Jir9v01+nkb7zo57aQ==", "d05b8095-cd7d-4d09-b5c7-e886c4189e43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1306d89-ab99-4951-8fcc-7665e402a01d", "AQAAAAEAACcQAAAAEMpQsA9IF9D1sW5LzGeNM9bDvJCMiobFioVrN0UL+1Ucyot1fCpjiu/7Ed68w/hJDQ==", "9a957354-97f1-4021-8e69-fbac9fa99a2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "558fd899-0222-4981-b3f9-07df8f524799", "AQAAAAEAACcQAAAAEGYuA80zdJ0hv73/DLNDzdccfnm5SLYwZJAfqo3DXGadAcCq0if5tuAc9i9Xj9NtVA==", "ef1d1450-dd8e-4cda-a750-bd5552ff5f34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4a91ff8-b9c9-4e97-89e2-0cfb302fd736", "AQAAAAEAACcQAAAAEJJ9TYYxQBg5v3DM9ncB/W2BgAo6BKWTy8Se8Cpq1+BJ7bRVF9pbH5+/hrwNDSKbYA==", "6943fa3a-14cb-42f7-97f0-69bdb13cb34c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d792eb7-14c4-45ee-97e0-b8f04aef272c", "AQAAAAEAACcQAAAAECrNS7Z+AJV2zVNg1Im5uPQ0+HEbIXEKpz8W4KjE+wBG8WR56rWmXTNBgLzkSi/mOQ==", "6b812a89-eefd-46a7-8fdc-4b14690bc81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d16640a5-36e9-488f-9f87-497e74214807", "AQAAAAEAACcQAAAAEI9GWT+Y6vTVS+JVK5c5pabu5bpNQy/Tx9l9SSNr93bhFPs9CTbEwf9SeIo+3qkBMg==", "a92bf110-6272-47c8-ad0a-86778efd885a" });
        }
    }
}
