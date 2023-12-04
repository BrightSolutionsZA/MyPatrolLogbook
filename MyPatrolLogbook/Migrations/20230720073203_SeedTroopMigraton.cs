using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class SeedTroopMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c965aca9-6d6d-4979-ad1f-3370f364743a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "53e97920-d435-4793-82a0-8a79bbe00a66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a4821078-0042-4eb1-aae6-be325edad4b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "8f82ff1e-c18b-4cee-bece-f5b0f13c3dc2");

            migrationBuilder.InsertData(
                table: "Troops",
                columns: new[] { "TroopId", "ProvinceId", "TroopName" },
                values: new object[,]
                {
                    { 1, 4, "57th Trafalgar Sea Scout Group" },
                    { 2, 9, "2nd Rondebosch Scout Group" },
                    { 3, 8, "1st Ikageng Scout Group" },
                    { 4, 7, "1st Isago Scout Group" },
                    { 5, 6, "1st Nelspruit Scout Group" },
                    { 6, 5, "1st Polokwane Scout Group" },
                    { 7, 4, "4th Durban Scout Group" },
                    { 8, 3, "1st Bryanston Scout Group" },
                    { 9, 2, "1st Qwaqwa Scout Group" },
                    { 10, 1, "1st Vincent Scout Group" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Troops",
                keyColumn: "TroopId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0032aa59-de96-44b8-b1f3-6c62ea2a148f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5fd63dff-7495-41e0-8f79-993c321128d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "373ede28-d948-4878-961d-0741aab5912e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "c7dde4d5-2a0f-485f-b340-95cc7f30d1a4");
        }
    }
}
