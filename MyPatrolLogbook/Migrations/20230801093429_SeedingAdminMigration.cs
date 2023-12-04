using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class SeedingAdminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsPatrolLeader", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PatrolId", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a1", 0, "c3166b03-eab8-4cfe-942c-4017a337eccf", "mpl.admin.ec@gmail.com", true, "Test", null, null, "EC", false, null, null, null, "AQAAAAEAACcQAAAAEJ/AV746Lt3VoosGvIkK8UAjlF0OmMtVETlRpTG+sdRvL2xQ0UwpTb8KnamG3g3q2A==", null, null, false, "1", "a192a640-afb2-4a52-96a9-a157219d7b9f", null, false, "mpl.admin.ec@gmail.com" },
                    { "b2", 0, "43b714c6-5f69-44e8-b43a-6551a90e6553", "mpl.admin.fs@gmail.com.com", true, "Admin", null, null, "FS", false, null, null, null, "AQAAAAEAACcQAAAAEC6alWN8zZDgYYEOORpEnosid5TeAZWSL5uXMiqFxwzPE5flDp+tgy4CN43ag1ZTLA==", null, null, false, "2", "969bad92-3800-4689-bfa4-ad7cfcdfe012", null, false, "mpl.admin.fs@gmail.com" },
                    { "c3", 0, "8a3ffc22-8159-41ee-b8f7-983fd153c183", "mpl.admin.gp@gmail.com.com", true, "Admin", null, null, "GP", false, null, null, null, "AQAAAAEAACcQAAAAEGDzH0ESev/xq+dARWrocmzZkc9Lh+V5UYidnCRi+IlcMCyGgpcMhy8yIwoJPOhvIA==", null, null, false, "3", "e1085007-023d-497d-906c-db6a67e5ba81", null, false, "mpl.admin.gp@gmail.com" },
                    { "d4", 0, "f68e9952-3177-4c36-bfe6-6a9ce15bdc43", "mpl.admin.kzn@gmail.com.com", true, "Admin", null, null, "KZN", false, null, null, null, "AQAAAAEAACcQAAAAED45ECMuNgOYWB1uRfVYjcmAFSOhD0nDGvu37GMcs9EdJKh9Jir9v01+nkb7zo57aQ==", null, null, false, "4", "d05b8095-cd7d-4d09-b5c7-e886c4189e43", null, false, "mpl.admin.kzn@gmail.com" },
                    { "e5", 0, "b1306d89-ab99-4951-8fcc-7665e402a01d", "mpl.admin.lp@gmail.com.com", true, "Admin", null, null, "LP", false, null, null, null, "AQAAAAEAACcQAAAAEMpQsA9IF9D1sW5LzGeNM9bDvJCMiobFioVrN0UL+1Ucyot1fCpjiu/7Ed68w/hJDQ==", null, null, false, "5", "9a957354-97f1-4021-8e69-fbac9fa99a2d", null, false, "mpl.admin.lp@gmail.com" },
                    { "f6", 0, "558fd899-0222-4981-b3f9-07df8f524799", "mpl.admin.mp@gmail.com", true, "Admin", null, null, "MP", false, null, null, null, "AQAAAAEAACcQAAAAEGYuA80zdJ0hv73/DLNDzdccfnm5SLYwZJAfqo3DXGadAcCq0if5tuAc9i9Xj9NtVA==", null, null, false, "6", "ef1d1450-dd8e-4cda-a750-bd5552ff5f34", null, false, "mpl.admin.mp@gmail.com" },
                    { "g7", 0, "e4a91ff8-b9c9-4e97-89e2-0cfb302fd736", "mpl.admin.nc@gmail.com", true, "Admin", null, null, "NC", false, null, null, null, "AQAAAAEAACcQAAAAEJJ9TYYxQBg5v3DM9ncB/W2BgAo6BKWTy8Se8Cpq1+BJ7bRVF9pbH5+/hrwNDSKbYA==", null, null, false, "7", "6943fa3a-14cb-42f7-97f0-69bdb13cb34c", null, false, "mpl.admin.nc@gmail.com" },
                    { "h8", 0, "0d792eb7-14c4-45ee-97e0-b8f04aef272c", "mpl.admin.nw@gmail.com.com", true, "Admin", null, null, "NW", false, null, null, null, "AQAAAAEAACcQAAAAECrNS7Z+AJV2zVNg1Im5uPQ0+HEbIXEKpz8W4KjE+wBG8WR56rWmXTNBgLzkSi/mOQ==", null, null, false, "8", "6b812a89-eefd-46a7-8fdc-4b14690bc81d", null, false, "mpl.admin.nw@gmail.com" },
                    { "i9", 0, "d16640a5-36e9-488f-9f87-497e74214807", "mpl.admin.wc@gmail.com.com", true, "Admin", null, null, "WC", false, null, null, null, "AQAAAAEAACcQAAAAEI9GWT+Y6vTVS+JVK5c5pabu5bpNQy/Tx9l9SSNr93bhFPs9CTbEwf9SeIo+3qkBMg==", null, null, false, "9", "a92bf110-6272-47c8-ad0a-86778efd885a", null, false, "mpl.admin.wc@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2d4bbae4-f1c8-44a7-b5cf-11f77aeefe9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "628a8a44-5724-4eaa-b9f9-9d4352f00974");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f666be3d-5f91-455e-a529-6c781ec1195d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "8f69561d-49c3-4532-ae2b-56bcf431db3b");
        }
    }
}
