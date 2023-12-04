using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class PatrolCornerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "276ef22f-b045-42f9-9c09-06788d04fb45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46d69b27-f270-4d7e-9fd3-a0ff53a03084");

            migrationBuilder.AddColumn<bool>(
                name: "HasPatrolCorner",
                table: "Patrols",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1ea3c385-922f-4eb0-a61e-fead6df1371f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4420aaea-6c66-4169-8663-1cbb92cfb686");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cb9410c4-2d45-4185-b542-152975bae1a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "769e28e1-e47a-48fd-b2fd-3cca38dc63a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f856e4-e58d-4b81-9ed7-4cb2b902e345", "AQAAAAEAACcQAAAAEF2L5D2XpqYIB7TGjOi++8XixNYm97CFnomsbQ6JYCH8c+tE/E5W2VMAWpVNBXY2gw==", "f9122bf7-6109-4de7-a49a-80f286c0e2ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dde3f975-04b4-417e-a023-63791e87da62", "AQAAAAEAACcQAAAAEGOl2bHG2zcasConSjbzWlkQpwQFGLT909BF3EcF4oCbiB87B6wxqRU+foIObLmjNw==", "20f65f32-21b4-4c47-b538-dfcf3fb523aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19e00a5d-bc5b-460e-b322-84b172be7676", "AQAAAAEAACcQAAAAEE8PV3KrKJRrJS2b5lFDu/B7oy1R+VqpKsxpWkoFktO+Ce7nNAe5M4ej90ZZYz5q4g==", "7de69bcf-0160-4428-b902-fd7c0b034041" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39761b69-1aef-4754-933f-ebd340e06bfd", "AQAAAAEAACcQAAAAEFhdVvw/BbTXT4mR7sAX2uhQfzG2Wfz8oBBoqkqj2TMjx4ty8qn/GyEuLDm0p7Um/Q==", "4b00dc3a-ba70-4327-925e-755500bbd01c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06b997fc-33f7-490c-9404-004f719adf17", "AQAAAAEAACcQAAAAEOCctLvn1IB1NZYUOwvKiG0fv/jC3cMV1FaqDLYCOqBN4HgT7SlRqYwcuL3OQSl80g==", "64388df8-4094-4c9f-bc88-8a4510f692b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06abddff-26be-4a2d-b489-66e355eb9def", "AQAAAAEAACcQAAAAEJ1OyQjmOPBvsOtcvPDtlZAJFDBtdcTQ5/YleE2flNKqqYbYxfbxMYAAHou7S7vnwg==", "2fad5ef1-e589-413e-9ab5-055831f62bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50157dac-10d2-48b5-ad9f-4ade790b5549", "AQAAAAEAACcQAAAAEMCvOYBuQ2xvZUUnirIZC/ixQd/gR16ybvEp7jQZQQ84V+G5V39939Zdq151f2339Q==", "d98b3a35-227e-4bce-bf7a-867ca9d21650" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02863532-b062-43db-be96-3a272c792513", "AQAAAAEAACcQAAAAEJBFJhWRrdd5v0fwnkI/wkYyD+w82i3OlVNMJa3BEigzApM9iYGC9prz6/1pU8Fa7Q==", "d8563c15-b064-4383-a0a1-3fcad2dffbc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5223cf54-5102-410e-9098-a75823aea1b4", "AQAAAAEAACcQAAAAEMgagLsgTf1KXM7xFAWnIvpfxNmKfzwKvDBTAwY3+REEmcVclfRyZDOptQcyc1fKjw==", "1c5a8598-4417-4918-a8ea-d73f35030ed8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "CellNumber", "ConcurrencyStamp", "CurrentAdvancementAchieved", "Email", "EmailConfirmed", "FirstName", "HasAttendedTraining", "HasNationalChallenge", "IsPatrolLeader", "IsProvincialAdmin", "IsTroopScouter", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumDiscovererTheme", "NumFirstClassTheme", "NumSpringbokTheme", "NumTravellerTheme", "PasswordHash", "PatrolId", "PatrolJob", "PhoneNumber", "PhoneNumberConfirmed", "ProvinceId", "SecurityStamp", "TroopId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e4b4eb4-0413-4ae9-a74a-0b22428b7779", 0, null, null, "3062570e-6e67-4c2b-8b2c-a1544c8e7f4a", null, "mishka@gmail.com", true, "Mishka", null, null, null, false, false, "Moony", false, null, "MISHKA@GMAIL.COM", "MISHKA@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEP7bQA9NY+ZeYBYfCJEXbwsXj+s/3rF++pdXsr+cNfe8BfMU1viZQA8otWYwR2GQlw==", null, null, null, false, "1", "d69b7249-4c98-4252-9eac-2baf474ce31b", null, false, "mishka@gmail.com" },
                    { "ff29d7bd-075a-43d7-9b4b-99c4b73b9f82", 0, null, null, "e7963671-0f42-41ae-93f7-2500ce17c953", null, "anushie@gmail.com", true, "Anushie", null, null, null, false, false, "Moon", false, null, "ANUSHIE@GMAIL.COM", "ANUSHIE@GMAIL.COM", null, null, null, null, "AQAAAAEAACcQAAAAEFY8FMOZ1K1lAYjL+s3ITsjButImAon7MLTMbopTlkO8lHENI3PXdJa/H42IZISGkA==", null, null, null, false, "1", "c342c604-52b3-44b8-84fa-d34c471e5afd", null, false, "anushie@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e4b4eb4-0413-4ae9-a74a-0b22428b7779");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff29d7bd-075a-43d7-9b4b-99c4b73b9f82");

            migrationBuilder.DropColumn(
                name: "HasPatrolCorner",
                table: "Patrols");

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
    }
}
