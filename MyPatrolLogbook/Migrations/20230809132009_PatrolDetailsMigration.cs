using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolDetailsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "688ebc97-e111-489e-91b8-ec4cb257a830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f58c626a-7577-4053-a57f-f3b74799a8af");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAdvancementAchieved",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasAttendedTraining",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasNationalChallenge",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumDiscovererTheme",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumFirstClassTheme",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumSpringbokTheme",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumTravellerTheme",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatrolJob",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ee1e7342-bfe5-4c84-b350-f48b1668019c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7098fcea-76d6-41f7-a49d-cec6b6010eda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7c691419-e787-46bb-afe1-7b81b28fde9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1204d178-387e-45c1-8270-399d1352d914");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d999d290-4182-43d4-bc2f-3d59216cb76c", "AQAAAAEAACcQAAAAECaP45RaoHJLssJi0r5YBphDi1vCSmrzHSomdLuwpslqK0OyWeS8BYk33oCwSkPS7w==", "9b1a910e-daee-4f90-92d5-3f135bc18b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8127cfb3-ca01-41a9-80f3-eea1c1322012", "AQAAAAEAACcQAAAAEHWT356c6p1QqF/dsX09XXhbaHazvLLitRcNM3WPfvRC9OlVNt0Ljdd640klqg1WRQ==", "8dcfeb59-5a76-4cce-9d17-cb74fc6c1396" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9912da96-cf3c-4db0-9e00-44f66b15e814", "AQAAAAEAACcQAAAAEDTUdBNVPcp9XIN295K2YcIpEWF6V98haNQp8TkrFq8393XBnzbwBv2abK+0T5KJ8g==", "018be4c0-3a25-4e31-a79d-e3445bb5ccd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49757d2a-d784-4080-b815-5f0a03dde182", "AQAAAAEAACcQAAAAENmOOoEceAl7GR/quTgZWr4yV7CQXX9fiPFe+etAdNjEFq/ddMvpYO63oFXMtymibg==", "f3ec3f09-ee4a-4762-8bca-02013eec5c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59216d34-3294-4e80-b98a-31b9098666b2", "AQAAAAEAACcQAAAAEOCg2q/S0GXvSH/Hi2sQWRpQsfFje93QfkEeZeU5Ptep5sKOKE0pOu7o4Z7MhtXbXQ==", "4c6902eb-fde9-4d2d-bc1b-f9a686a1a9e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e5b5297-b599-49c8-9a57-4142f0bf1413", "AQAAAAEAACcQAAAAEA6CLMccITdC2NCIxqoXI7HydSkKm17ozwQIo8bwXBC9g0tNC1oE7dy6OWXii5zNMA==", "ffa49412-584a-42f9-be48-05aa1beefdcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23e51ce4-0e65-4641-9b0b-be4e18c4669f", "AQAAAAEAACcQAAAAEFXepCQAdEk4bPm5qNeVCTq83x/nirSy4C96B3AuzHUq1XnalMRtM6qkxyzJTNo5fg==", "65c4c67c-f648-4eb5-bf2e-6071e2a3a157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12472c2a-37bf-4f66-bfdc-7e5905cd6af7", "AQAAAAEAACcQAAAAEC6yPcaUAfFIhOd475RRNha5/52/J2bOkmQxGKHYoqQ5unt9W71b6SbExvHKhTojhw==", "b6f35cb5-48ea-46f2-a150-586bdf9b85a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aebcb9cc-e9f2-4eae-9141-18ae8f0dc0fa", "AQAAAAEAACcQAAAAEO1x65olSe6vaf8ZNJJBbFjN+XQED2iHe536ooYG7AnPMBFFj7RCWJU4l8trmMVPDg==", "3c2f138e-ea71-40bc-a54c-f6774e14230f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e44fab2-4e04-4e87-9b28-04b04023dbbb", 0, null, null, "ee7a6a6d-6f49-4dc2-93f1-4ebc7974d4b8", null, "anushie@gmail.com", true, "Anushie", null, null, null, null, null, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEERMD47SIqbR24VvUK00t85YsOPJTqzviOVg4hrzvukh4/PpUBSKCAj/6SUeMffLSQ==", null, null, null, false, "1", "0f3ea7d1-61f9-414f-b1d8-35f31cfcf6dc", null, false, "anushie@gmail.com" },
                    { "c8f11fbc-8dcf-4a08-bcdc-c569ed4b5c07", 0, null, null, "f68e31b8-97a8-4607-a310-43e5429f6cd1", null, "mishka@gmail.com", true, "Mishka", null, null, null, null, null, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEPMd7OId56RH1nYswjKozipnSFqXpfloWaplSxbT8kade7mvs9aX2Yo1hMq2LQWicg==", null, null, null, false, "1", "ef5c76a8-8df7-4590-a8d3-5f4ae4b77593", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e44fab2-4e04-4e87-9b28-04b04023dbbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8f11fbc-8dcf-4a08-bcdc-c569ed4b5c07");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CellNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentAdvancementAchieved",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasAttendedTraining",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasNationalChallenge",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumDiscovererTheme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumFirstClassTheme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumSpringbokTheme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumTravellerTheme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PatrolJob",
                table: "AspNetUsers");

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
    }
}
