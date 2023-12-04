using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class IsProvincialAdminSeededMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProvincialAdmin",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7507cf8-d0d6-4fa4-920a-11d702904065");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "22817af1-d544-431e-8a9b-1d38b92b47c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e4a991aa-a295-456d-8ab3-4577143aa5f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0d495a57-8687-445c-b475-7ea1b0648663");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76bb9b07-11a5-4313-955d-2203fd13739b", true, "AQAAAAEAACcQAAAAEC5JqSPEGN0bNB9LcwC9g29qOPJj6mj41E5JYtEy2G1+03yAjVo29xJyQ/1b03aCgA==", "5bf381d7-6242-4e9a-aaad-6351226da525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6647382e-2974-4b69-b7be-4caac6a75e2a", true, "AQAAAAEAACcQAAAAEH4NXS41kpWi2dUEVseKg/4zGNAgwxX1TJPT8zaB1ZdiSdF52cBW4pthbr+W2lV64A==", "7259dedf-eda4-4698-93f5-d13a2ae687e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d885696-82e1-4873-a965-3feaa659829a", true, "AQAAAAEAACcQAAAAEI/Z9kfOJ0NLZum90xBq5N0njIMcvWLhEjV0uBXNRmp1Uq+OgWR7IopzNcXlVncb5w==", "ffc030f6-7746-460c-9a50-ccebec8c58a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da15a53-d32b-41ba-9bb4-abbe67261a4f", true, "AQAAAAEAACcQAAAAEKN61H5AGSzyahO0zqrgscQlqlr039XldCeDuBC6mzVamw+5ilsS0b1rRlwvd7yHYQ==", "f5d0bf74-fda1-4171-a767-ffb01bc0a402" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e5e2b5-42d9-4aad-9ccc-537ea1f54f71", true, "AQAAAAEAACcQAAAAEHqviVfqaG+BCnFyVDuF0B9wa9mzWIqljOUKTL6rR/TESqOM9DNPlprWw3DB2HHmNQ==", "d7edd4ff-d7d3-499a-a5b3-f6ea68154aad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9903b52a-24d6-495f-a96f-e1fbd14fa3a8", true, "AQAAAAEAACcQAAAAEL2S88dUL2FQ0zi/ZJxS6q5ZavhlVI9Zn7ade4+XwJvQKP9yChMQ70OqAB4p6tMFPQ==", "d1cbc19a-0daa-442f-aece-5d1ecef717b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "186e769b-d7f3-4a67-ab72-3bbe4938029c", true, "AQAAAAEAACcQAAAAEBmDNVm03cK3zCnNSflQ9SO5zt8uzk9GGo7F7ZVOpJTQO/e5skUhpfRulXwVNFujGA==", "9f7720c9-f808-4c1b-83dd-ed5782a756ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cc7024-8262-4ac7-b47a-de6605a682aa", true, "AQAAAAEAACcQAAAAEKKXvWSrENALxpOPtaBllV5hRxRcUhWMjOgn10cgl9IDS47g/F+ccBK5dp1TiPNlGQ==", "82015892-3e13-430c-a4eb-fc0e019ed73e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "IsProvincialAdmin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f982c5-a8be-4e88-9bc7-29a5a0f121f8", true, "AQAAAAEAACcQAAAAEFj5NQdwWwIfMBpmwvAc65fu4guQB9nXHhDphACh71CoSVhdL+K9CZ7s3r6pqHWSFg==", "3befa741-37e5-44da-bab9-db212f6b7c6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProvincialAdmin",
                table: "AspNetUsers");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b3d7a7-c971-4c49-9482-085dc950de3e", "AQAAAAEAACcQAAAAEFu0zkiMEMTQb7z3fpJlcvo0fDqtur9/pFmkFaVc2yeNMQ4RvUjlY/wSf0ZpClMHtg==", "97e432d1-ccb9-460d-b526-6e0432bb8093" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcc1a3e-ed81-4d20-9fc9-dd18433cbaff", "AQAAAAEAACcQAAAAEEFiWRmnq62ltXJk5AQOa4eWzJjDx0PcPOBNcT7wreES8huWFhiomjqwqkGkCpmAnQ==", "6a324393-c682-48d0-8cb4-9cc7fd215b49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad013de-1f67-4d5f-b79d-f8d927ec9ed0", "AQAAAAEAACcQAAAAEPjf3cIBhu4DioA+rv7BoSduREE+LhifCVea4VC6jCZX4nJWjt33jqCXumK5o1qLSg==", "5840f838-0a20-47cf-9022-61e227d3cd6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff7ce8b3-92a0-4f12-99b5-fdf6b84edd0c", "AQAAAAEAACcQAAAAEDH4CUGDM/r8BSVi1HGM7UbOPIHUyj4ivlGHesQU8B2yh0ugClDEkP3M3Q3wG/O8wA==", "79b4cc14-9a20-482b-97e3-a969f7d257bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8868357e-b578-447f-b431-92b24a640bd2", "AQAAAAEAACcQAAAAEMWapBJfbEFFvRBs7h8A3JTafTduK+sjFU255ASrNuEr4xrjtmwNeexkG7jNoLcfNA==", "f5cb9534-ddea-4b1c-885c-67589f91907a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d28526bc-cfa9-40e1-bcc9-9919c47ab973", "AQAAAAEAACcQAAAAEPU1RRPHnaGo1yGx+RnC4aUQPr+AJXbm21q2lparF/KZwuMspSOH47Asg1Feyd3lug==", "d43e18da-ae91-4654-8b76-e1e9b75090d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7afeb9-6e0e-4ed2-937c-422bc02cd534", "AQAAAAEAACcQAAAAEFpJ0w1yctwiRQSQxO+OhQ4lDnRT7QIwVPrfgXhgQ+riD6Xds4ndhK/bpMfnMzjjhA==", "a6315f13-9f73-4b7a-bdb2-c1eb58518dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb34853-0cc1-4c27-81eb-11628df0e65d", "AQAAAAEAACcQAAAAEHPfaeGskzwaDs/4PFgcKPSBcQBaIiGcH+3U6i6Mvspw/8/zNmZHb+LZ0Wv03bfnag==", "463bd40c-3aa3-4c73-8bfc-c780e52ddf39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9b1aec1-caca-46a4-99c0-a74c1a80ceec", "AQAAAAEAACcQAAAAEI07FniQnIw6Kq7ypldWQvtztqj+2mbkvcPmCuna7lEdvZrYujYY4HahRSHx/xlD2Q==", "6ad02062-4744-4c9e-a32c-d623a9de3d95" });
        }
    }
}
