using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class ProvinceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "fa52cb54-7c86-4a2b-b982-e082214ecf23", "SuperUser", "SUPERUSER" },
                    { "2", "b0e0aed7-f985-47a4-90c0-57216d7f873d", "ProvincialAdmin", "PROVINCIALADMIN" },
                    { "3", "ed6c23ed-048a-45b0-8d4b-ae54b2df6299", "TroopScouter", "TROOPSCOUTER" },
                    { "4", "607e71c2-8b7c-45c6-9ea2-47748cbf36bf", "Scout", "SCOUT" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Eastern Cape" },
                    { 2, "Free State" },
                    { 3, "Gauteng" },
                    { 4, "KwaZulu-Natal" },
                    { 5, "Limpopo" },
                    { 6, "Mpumalanga" },
                    { 7, "Northern Cape" },
                    { 8, "North West" },
                    { 9, "Western Cape" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
