using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class SeedingScouts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7a4747fe-5309-4927-ab8f-6e40b5a1455c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6e26760c-7d0e-4fea-a8e9-ba4088cb596c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6e760ef0-2a46-4364-b3ea-2f34c11c7d38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "bc13a537-5db8-4d50-bafa-ec660b68400d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f138f52-08b3-4101-bda2-5027e02f8668", "AQAAAAEAACcQAAAAELLPI6EnB0UMxfqJReP1oZGyMxVxfF9wRNz7+efMsfKWSRB1T4owFPrM+FuL9CCPMQ==", "07420c6f-d490-4501-a163-5b87b87465e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a519823-c888-47e1-9365-daa192b0eeb8", "AQAAAAEAACcQAAAAELLhv/nLDg8X0QFIRrA/jjyU9vBNQbdSXZDjloRRvDUEW6g0lYIAsOapGhNnBA3HjA==", "94dfd6f4-5823-445a-bf50-67bcc5e8e065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbce8a8c-187a-463b-8a05-201597b3673c", "AQAAAAEAACcQAAAAEIcTMIA1QoIjectSmX1AP+UyUPWbv8F1iegLv9Wpb+5NAn3W6lXRJvfaSnsyU7pPAQ==", "812b5859-8691-45e3-bbb5-aa7f5d582cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c9c38a3-a88e-4309-a5a8-80883b22f3b1", "AQAAAAEAACcQAAAAEB+yk9GzhwB26OGL7TzrbbURvwL3eve+yKKH6HLZSLpNLRF1tobyBC6/fsP++Yy7mg==", "e2d83a0d-b87a-4bd9-93e4-f78497fd8b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b82b42b-b465-47b0-a443-22ff291c071f", "AQAAAAEAACcQAAAAEKV645PjvS8ucUtm89G9C72ex6bkzC8LgyYM/nsZqttXIiJjP3p3wEFdyUVQW2L6xQ==", "ced2a0a3-9a3f-4749-9b8d-7727139a5518" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b83d219-81c2-488a-9d5b-29baa9b9ae2e", "AQAAAAEAACcQAAAAEDkmUvA1ya52INTWPkYptWclbUK5ryhUy/DR+lY9sytgBsnIRr6kZ3vQ5ucIQ91beg==", "30e2a23d-6105-4c26-8586-9b7e5c042e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6476dbd7-2d8a-47c2-bb16-b483e46c5a56", "AQAAAAEAACcQAAAAEG4cBnHsqAKECuNrm+jicRmD5rh54u5Z/B5z5uQBDl6r6K0x1PSuxkpkx7WqkkazsA==", "757c1675-ca7c-437c-a968-a8197781f87f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41a230a4-1967-4b32-b3c1-2da355f1e5f4", "AQAAAAEAACcQAAAAEMd6nbODx0OdELbnm2b4JdAGt9lWfwr2tDzZuwRI+a9SeMuJN/g5kITMpeNNbK3zdw==", "3a947247-71c2-41fb-9153-6ebe8744a19b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e914cf7a-1447-475a-8afa-d8e29f8fc1aa", "AQAAAAEAACcQAAAAEIXWs3rXyyojnxDVNzfg6CDRvcY/P5iOD0NhptGNoyMNo48UZ4GwJkyKuxfci/YTdw==", "b88aa236-4844-49ab-bf19-ddc8d8adb345" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PatrolId", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "688ebc97-e111-489e-91b8-ec4cb257a830", 0, "8ed360e9-f10a-45a0-9ae9-125568e2ee48", "anushie@gmail.com", true, "Anushie", null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", "AQAAAAEAACcQAAAAEIPUIx2/qjB/DqHn9rTtX0meacLKqCozdLjbazL2pMOquWUGoC3IlWNi+7P+OQ82YQ==", null, null, false, "1", "1159a338-26ed-40a4-b6ce-e6bd4caba029", null, false, "anushie@gmail.com" },
                    { "f58c626a-7577-4053-a57f-f3b74799a8af", 0, "3a57b274-25a6-4e26-b960-4abf0ca211a4", "mishka@gmail.com", true, "Mishka", null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", "AQAAAAEAACcQAAAAECt+7TzE2sGGbPKvxkaZYy5JSTddkZt8I2/1zlKr+k3IXOCQBtDZW++55NujpTA6ng==", null, null, false, "1", "6130079d-c95a-43a3-a3ff-3b76c126a4aa", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "688ebc97-e111-489e-91b8-ec4cb257a830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f58c626a-7577-4053-a57f-f3b74799a8af");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76bb9b07-11a5-4313-955d-2203fd13739b", "AQAAAAEAACcQAAAAEC5JqSPEGN0bNB9LcwC9g29qOPJj6mj41E5JYtEy2G1+03yAjVo29xJyQ/1b03aCgA==", "5bf381d7-6242-4e9a-aaad-6351226da525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6647382e-2974-4b69-b7be-4caac6a75e2a", "AQAAAAEAACcQAAAAEH4NXS41kpWi2dUEVseKg/4zGNAgwxX1TJPT8zaB1ZdiSdF52cBW4pthbr+W2lV64A==", "7259dedf-eda4-4698-93f5-d13a2ae687e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d885696-82e1-4873-a965-3feaa659829a", "AQAAAAEAACcQAAAAEI/Z9kfOJ0NLZum90xBq5N0njIMcvWLhEjV0uBXNRmp1Uq+OgWR7IopzNcXlVncb5w==", "ffc030f6-7746-460c-9a50-ccebec8c58a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da15a53-d32b-41ba-9bb4-abbe67261a4f", "AQAAAAEAACcQAAAAEKN61H5AGSzyahO0zqrgscQlqlr039XldCeDuBC6mzVamw+5ilsS0b1rRlwvd7yHYQ==", "f5d0bf74-fda1-4171-a767-ffb01bc0a402" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e5e2b5-42d9-4aad-9ccc-537ea1f54f71", "AQAAAAEAACcQAAAAEHqviVfqaG+BCnFyVDuF0B9wa9mzWIqljOUKTL6rR/TESqOM9DNPlprWw3DB2HHmNQ==", "d7edd4ff-d7d3-499a-a5b3-f6ea68154aad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9903b52a-24d6-495f-a96f-e1fbd14fa3a8", "AQAAAAEAACcQAAAAEL2S88dUL2FQ0zi/ZJxS6q5ZavhlVI9Zn7ade4+XwJvQKP9yChMQ70OqAB4p6tMFPQ==", "d1cbc19a-0daa-442f-aece-5d1ecef717b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "186e769b-d7f3-4a67-ab72-3bbe4938029c", "AQAAAAEAACcQAAAAEBmDNVm03cK3zCnNSflQ9SO5zt8uzk9GGo7F7ZVOpJTQO/e5skUhpfRulXwVNFujGA==", "9f7720c9-f808-4c1b-83dd-ed5782a756ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cc7024-8262-4ac7-b47a-de6605a682aa", "AQAAAAEAACcQAAAAEKKXvWSrENALxpOPtaBllV5hRxRcUhWMjOgn10cgl9IDS47g/F+ccBK5dp1TiPNlGQ==", "82015892-3e13-430c-a4eb-fc0e019ed73e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f982c5-a8be-4e88-9bc7-29a5a0f121f8", "AQAAAAEAACcQAAAAEFj5NQdwWwIfMBpmwvAc65fu4guQB9nXHhDphACh71CoSVhdL+K9CZ7s3r6pqHWSFg==", "3befa741-37e5-44da-bab9-db212f6b7c6e" });
        }
    }
}
