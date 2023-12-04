using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PICMigrationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b62f2ca-52b7-41c6-9314-db1466a0a24e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c51d7405-1dc0-443e-8260-a1eef425f319");

            migrationBuilder.AlterColumn<string>(
                name: "PICPoints",
                table: "PatrolInCouncils",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "892c9b0a-9a80-459a-82bc-42107180b3c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5fab41c4-97af-426e-ba81-42db7ff989d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6ac037f6-922f-4199-93e2-d518de851e5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a87e9d9e-5242-45ee-bcdf-75d6eb8ebe8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf5e923f-de9b-4e3a-8ec8-03e6c207789f", "AQAAAAEAACcQAAAAEF1n9YE0Ta0n9NzpFgxV0vWog/R+rST4FgIrfofbIUrr8xafxDAnPOWqr+7aMi28+A==", "d3a6ecc5-a4e1-4f80-8edf-0f59b91aa768" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "009bce74-4419-46ab-9236-1be5751a975a", "AQAAAAEAACcQAAAAEMA/97VQhnBD/r+fMERZiF4/9HndjrL00cpw33RxXxf+f8StPCzvjSD4eeWglKILPA==", "f64eb0a3-1348-4d12-b58b-0fd6d2288f3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "130b7488-c1a2-4c41-806c-cb0600dde3e3", "AQAAAAEAACcQAAAAEBlSMDMu/gGbrWAcg2H+tmBSEVO6H6iUxgnJgQheY4sgYGKDVZVSPb9uCrWf1Oo5Zg==", "9fa4efb4-5b49-4646-97fb-466a20c69ae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e603e61e-c3dc-433a-9aec-50517f7e3cd5", "AQAAAAEAACcQAAAAEJXG4i1iKkKNgE96n428dDSMmF+TwXfelN9xzJoZIucKkKhg/epnHKxynizLsA5vuw==", "5820773d-1914-42e6-9e6d-1f1af3959f25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe22469-497c-4911-9cb7-d253df25adfe", "AQAAAAEAACcQAAAAEJaOT/7VDT90lfFpOK5Sw4VXns96KucJxjmYEKtegS/AqfRfkWRsivjAJET5sgPpaA==", "e042438e-afc6-4327-afe3-4a1b5ad34ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "222f6ace-d314-479b-b06f-3f22b985769b", "AQAAAAEAACcQAAAAEI544kgnTq/Mx7YwoSiGuylHmn+37xLbrKgT82HVuM7AgRnrwsyM/7kPhYN0Kd6ikw==", "4cd5459c-2c8f-46c6-b218-6dbce3274716" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06c12695-4f25-4f38-b4ae-335ff357ebca", "AQAAAAEAACcQAAAAEHyUelbVpPI1w76xv4283gw1ryEIhk6/E/ZioR08y/NQHvlhgduHxEVQ/mIt3YXZsQ==", "aa226892-6e73-4fdc-897e-60adc40262b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3a19e3-ff18-4701-bb52-e85452debd00", "AQAAAAEAACcQAAAAEMxuQ5tsIzKdeHXh2Sc6+mlZ5Yli4PviD67PC7xZeUeFVh/h1CP56VaDPL8sBLcEhg==", "45342400-a6a7-4d79-9112-e2ee8af1ba12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ee2e81-bd62-4f99-97d0-57b5dabb94c3", "AQAAAAEAACcQAAAAEFqjFd9hhSJsOVUvpJy3t2bQSsTl8n5u4jU6CYRWnZd++hHYnVSxcjXq9cuJqcWOLg==", "1b2d1731-0b3a-4c09-b0ca-a06e0684c0c2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "276ef22f-b045-42f9-9c09-06788d04fb45", 0, null, null, "f07cd027-831b-4ab7-8cf4-6912b08dff41", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAED4blxdk+4QdXQ2rGLND4JKFEAzd2XWG6WHKlHoOqgeUqrT4KIgxFRpq97iw5hcGXQ==", null, null, null, false, "1", "89a44a2e-4e5a-4291-8ecd-c85424ab9afa", null, false, "anushie@gmail.com" },
                    { "46d69b27-f270-4d7e-9fd3-a0ff53a03084", 0, null, null, "813d91f0-b402-471f-bb03-847f6db67b25", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEAr2H9bn4HPN+2YlZA/pWoOKXZdEwUd0bytESdvsYhK2R4S0/hbVIoSPYnh0MeubXQ==", null, null, null, false, "1", "76e59b18-3cd6-459a-9221-c47e9e94575d", null, false, "mishka@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "276ef22f-b045-42f9-9c09-06788d04fb45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46d69b27-f270-4d7e-9fd3-a0ff53a03084");

            migrationBuilder.AlterColumn<int>(
                name: "PICPoints",
                table: "PatrolInCouncils",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "41cb6f75-58eb-489f-9f11-ec4cb605a9a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "700a6abb-6eff-44eb-bcbd-4676bbb074b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "43ee071b-4a26-4d95-8d04-9d88c9c912ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "da0009dd-d7fb-48f1-883a-119bfa3d4073");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a76d40-9860-4ce0-9746-2c544619bba1", "AQAAAAEAACcQAAAAEI8EGRXfmqK2NI+YhfkcDtpXi1RlIJYrKRns2/sCQ7iPlDeQH3X/Fa6MPYcmGUMRcg==", "ef3a0569-a63a-4e5c-8392-93d032fa8d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799b9e1f-40f8-4a3d-81f1-df330eee8cbc", "AQAAAAEAACcQAAAAENziAtgRTuKofbX+q88GdPI+pp17kb3+Yl4gND92pfZJbkERdxEpYeDS5ze5/ltj+w==", "5788da4f-c41c-4479-a027-d33302cae5ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93655136-6b96-4903-8b7e-908fb182749d", "AQAAAAEAACcQAAAAEJOMPrveStf6GMqi9fa0shG+635NXE1nDqJ05kHKbo951o5zNcv0PM7lDy4n4J1waA==", "9929dc61-589a-414f-8efc-489e38026a5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d000e99b-5ef7-4a68-a0bd-50a8219a087b", "AQAAAAEAACcQAAAAEOelbXvDtaSggy1Fp6Y1f04nGaY8SoDyEYUwIe1K7KuxgJUwK044ot9rJDd1oI4hOA==", "34667397-76a2-4986-88ea-6d9a444f463f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6737279d-a9ad-45bd-9a57-682f20339f35", "AQAAAAEAACcQAAAAED9jsdEAtQfWEEIJZgv18443FBkwSQ63e72Vx2B+1vK17dix0gcXk05R7Nuqtx1sCA==", "fef73be5-557c-44aa-b7e5-8614a0684814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80c0fcf9-581b-4f19-994a-5f230ae4fa47", "AQAAAAEAACcQAAAAEH/ojWdax5Lt9S6Sq+GWHJHbZtcl24yqRNSVDnpautYJfo6XAvgcYEtmZCj+bJ7IDw==", "3bfedf59-050e-4343-8c57-6c36685af48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19700889-2ada-4479-988e-6e573e0fe2a5", "AQAAAAEAACcQAAAAEBhfDQLV8fqxztFHb6YZPNibgxU3LGcsGmtQYVmKi0iI/P93pW6B/HjMkrBgTP3phA==", "074498d8-7a0b-4705-8cd0-bb235719f231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47811c9-e1fd-4ab0-8e42-59be0138a941", "AQAAAAEAACcQAAAAEBdyyV7rreuo8881nf5Itscf+/oeA02ZkO5u5qFxtXH2WiEovlsGIGRcNRHV8qKotw==", "2d3c8fd9-ac91-48f1-a70b-dee524fdd0af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5126404-d648-4408-803d-0dbd1551028a", "AQAAAAEAACcQAAAAEJM76r0kxEot6ca/mB0gjxGX6PXX8NKzXqC6an6JLv7aXoWaLcIljcr59Yp3U9fYJg==", "276ea142-2ea4-4bed-8c6a-fb8aab623b59" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b62f2ca-52b7-41c6-9314-db1466a0a24e", 0, null, null, "7756915c-2bf1-4b2e-9fc8-1ae9832b95e6", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEBAH/v1cRYJ+coQ02gTLeViBqYOCSNDHKvxHJcJkZRrUGHLTKRwsLgTQM5yNqrIx1A==", null, null, null, false, "1", "a384c736-6ee7-49d5-bd5c-60063cbbbd4d", null, false, "mishka@gmail.com" },
                    { "c51d7405-1dc0-443e-8260-a1eef425f319", 0, null, null, "bf7b90fc-4f66-4a4a-85bb-3c2a04063245", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAECaKIURnCr0InoQoCkND/O8FfoNgpjI0AJuwi+mda+ProZCyPlpsyZWELCVRTXtw9Q==", null, null, null, false, "1", "4589566e-a387-426a-b726-412d391bf474", null, false, "anushie@gmail.com" }
                });
        }
    }
}
