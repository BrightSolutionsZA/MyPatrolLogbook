using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a9c55f74-9f37-41e0-96cc-b8281eb00f1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "81eec14b-d649-421d-8909-dac065bcff85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f35e7ca3-57fd-4c61-853f-ba2dc78137ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2470dac7-afc0-4d66-9f21-f82f7e20ea0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31555d23-38db-48fb-9407-7b7ea7091e13", "AQAAAAEAACcQAAAAEG2dXynUzDl+U/2PvCdMPOJdMy9LX5NgrZ1twn9i+4CHrbsjTZ4ozlF3JHUNnek24Q==", "2c7c7f2b-df9c-42f0-bee7-30f328ee8648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a0acf7-c07a-49c2-bb10-03e05ad97589", "AQAAAAEAACcQAAAAEFT/YSZtVBmr12oH/FRu/del0rHVrr2peXicDa4bYF+q98ETSYLasor3BXZ9jp/Zlg==", "05652f8b-d29d-4736-8959-59c85d330530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc22a390-ce01-466c-bf4c-1cfe34adf2ac", "AQAAAAEAACcQAAAAEJ7SP1F5WlrxPNJdGYLQv56jKU/ax5+KcQrmrQoKmoRlKgF5wePPei3nzuEFFdVbag==", "9ea060b2-29d1-4e71-838c-45e0de445f71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edda2de0-7728-4f89-94df-f6f05baa3cad", "AQAAAAEAACcQAAAAEEQihHtz61PHPU25ph5FXiV13uKHDW5tbfWD9YSBuYYZea824vLCDRqtHaKpgS8j+Q==", "961ed33f-adf1-4e54-bfc8-f358fdc3f479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6302ae0-e109-4a31-9b34-6f037dca90f0", "AQAAAAEAACcQAAAAEMjy1knfMdcg4IzeZQw5EtOXWTOdyr8rn/nUYwiEMBBM1PdzSvVXgmW1q7zwUZTxsw==", "18c07840-f788-48fc-8176-6f2c15981b1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8dcd18c-bdb3-4774-87d2-66a20c6d26ba", "AQAAAAEAACcQAAAAEMXu8zp0YmMGtUx5qpbrly4KrBj7WERW1nRCQKzI9iNm6Fs/sT50yXTtMFteiyk8yw==", "c1a49992-a6df-4f93-9008-245aea4a67ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f6f0855-17eb-4347-bfe0-c021fef72dde", "AQAAAAEAACcQAAAAEEAU+584CblyxHg5Pkji425uy4hU1kMlfRDEblqdiLpUPUauagLXyP5QKMrhnXPkVg==", "73bcfd89-3ef1-4927-91df-59834517a8b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f488dd1d-0e8d-4107-b916-a82ccf963dda", "AQAAAAEAACcQAAAAEKZz5mb4iAwXscWpGcEsJB/IkEG3tY91pXVac9NuecHSzcOzPD+jv94ha50c25U07w==", "4d3a224d-35cd-4691-bc59-796578c31791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "848489fd-8a21-4791-8d82-24d60557ee87", "AQAAAAEAACcQAAAAEFY98PhX90H7y1vy+ZFMDwpiU0fE83kzSGq42JjFMoVj0H/uNEUblVELKjcTSwcX0A==", "f7c6b71a-1a6a-40e9-a011-326c193569a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f333a32a-7cb3-4ead-a843-4070d300b083", "AQAAAAEAACcQAAAAEFm+R7ihp5vqONZs/yMzRjSPa4tJEtSsH/ZfE8quEG+cQ5Cu4O4/VPKgqHPq2rzm7A==", "9dc7acc3-1f52-4bbd-8ea7-85298b12a7a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "261a8682-89f8-48f2-aa58-684e48dc7ae4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4ef5c591-cdee-4120-a454-e241d9694185");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a09b2120-54b4-4e3d-a614-b16bf1f3bff6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "4b2a9b95-1b2a-4fe7-b208-5b1f28907cbd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17256f69-0196-4bb2-a665-41b51ee4b5bb", "AQAAAAEAACcQAAAAEC4g/iZS/gzQ/OpI6JGHFtPtKDLCfK5HabcIkcIPOcDAixfJ2nKgojwC//NQZlYVXw==", "dcfdcb79-b4d1-455f-9d61-8ff4a494953a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df217d34-0822-42ba-a146-649309d6f2e0", "AQAAAAEAACcQAAAAENNCHNtZY59qZoUDwZ7a1xoTVZysr097mRegLdhQp4pegdJsrZLb9wOgrzURzk6kJw==", "e22159d7-8f27-43ff-9a72-7522e2623ef8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "934b08a4-694f-4ffa-8f67-dd7cb34bcacd", "AQAAAAEAACcQAAAAEGoGOCiLbhVw6g+ooS4Z8F4AsUNHMctsTX3jW7fEUZMff/PtSScdjogDwxexf7K31g==", "cefcf951-c6d4-4805-b00b-aa7f7627d88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b4a6b6-757d-49c8-9181-bfbd38f6e871", "AQAAAAEAACcQAAAAEPxGFl8+/WKKFduD5roqvczPbC2aXAZQtXH+Jx3KAD5AHJDnOZenba2HXFdUMMOTXg==", "145a218a-b4f0-440b-a2ad-3b46018733e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddd29fd3-5142-41d0-ad46-209696fa70fc", "AQAAAAEAACcQAAAAEABlFOSXqGZNy1UWL+zofkzusmmVD79SUtGqCmHRjkzrbs2iAs4tL5nBG6dxtNVolQ==", "73c35b3e-591f-480d-a100-a6955d9c199b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c485dcb9-6c23-43d0-abb9-bf3ae143faec", "AQAAAAEAACcQAAAAEMpN8nch8yVknbdjkDivIA92P7TSJD5LSo0hT8Y/wR5naLpYvz5Vcf2WBBAvijcPsg==", "eae416a9-fc7a-420d-9163-5f23f220714e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a00d3f-60ce-4256-a7de-7a22a45a7037", "AQAAAAEAACcQAAAAEPriH0+Crjm6TGOJ00UQOqr5JW6IrXD5fJkhKYFRzjaqcYuDly7PzYlro2vPPZPT7Q==", "af256d63-938f-40b8-b67b-1ee857132fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da21fddd-fc3c-4908-b034-cd76cbec628a", "AQAAAAEAACcQAAAAEL6IyJKN6VISE7wVPjUfazP0C3AeWbZlyg4KIWgywRhkqfGC9Ykzyow3nt26R4dk+w==", "ce519f3a-809a-41d0-8e27-53113f6b6b3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb9c11cf-e486-4899-b39d-fa61d713ac46", "AQAAAAEAACcQAAAAECfyEWf4/uUMT54Wp37+xcGa9F/rOzt+xOVBktdaDZaaSlo9gSqvpCQw2xfx9ObI6Q==", "99bb3654-12b3-4a99-8082-5134396bc5d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a551f137-c212-4b0c-8016-e6e7c58981a4", "AQAAAAEAACcQAAAAEK5dA2ed2REi+PUA1mzkX4uBDsbjDkio9LzVExC0mOYSk4gG8o9Ym8NezXXi5fmxBw==", "04d62409-13b7-417a-aa15-b3474962e783" });
        }
    }
}
