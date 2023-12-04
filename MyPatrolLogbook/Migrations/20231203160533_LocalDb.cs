using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPatrolLogbook.Migrations
{
    public partial class LocalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6b738df3-bc36-4ee7-b44a-d22f55124f0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a2f0612c-2bf4-4cf3-9423-e28c53ab31de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7d060774-3814-4634-946a-9a3c69300dff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "8cd6c462-0fee-4d59-9660-488c8942890d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c02a0393-2895-4891-b2f6-7c5e69be5939", "AQAAAAEAACcQAAAAEMNZ8pukPXfigkiwHQ4qP4GlVIYakEbn1E9TbgwJcKKdxRanhWRulyIsLsQWr9Xchw==", "fd2632bd-1a04-4732-a09a-b9a5608a920e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9246aba-7591-442a-8d07-0d15a41425ff", "AQAAAAEAACcQAAAAEFHgI6dTLFz3nTgENWMTd1/P6T8yVCUpwBe9s5KgJ0RlxIB/fK7lhOZNrqQEJr19Lw==", "d028fc1f-adb6-4c87-826c-6d4531cbd232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c5798e4-bbaa-4a6d-be2b-48a54cc343e8", "AQAAAAEAACcQAAAAELM17UIMEEaVzCZ3WXI0ut2jlcoZrrxu8QlmtffNCC/PxtmJ0WuZpazbOb6VBypWfA==", "da49d4e7-e467-4867-916e-afe5367ed3d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871c664c-12d5-461a-b211-ea5dcfd9fcc6", "AQAAAAEAACcQAAAAEODPrARinDLYg6Qv26gsAkaFWhFORXBoLpKKK8RHKXoZXBDXBFmgolY7VS2OZqMrhQ==", "1cba2e4d-1914-4d8d-b997-df1aea23e916" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "464746b5-80ef-456b-bf28-e757514d5305", "AQAAAAEAACcQAAAAEBECaSo5kYR0GkHTDa2t6CPFdOyWNDpQY32v3kyL7epdrVwzjlh7tlWeWOtPFRf2ZQ==", "8305edbd-0d21-4478-a5c1-f3c2bc5d4bca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3755607b-a575-4212-aaf6-66e9e52ec166", "AQAAAAEAACcQAAAAEJdoGCwKeV09POxa1/jZjgTlsrBMHCegVbajHV3P84Q7mRUL0Rg0TtJEKyYZ7j4Ghg==", "a6c4fd98-e9b0-440f-be59-80722ec51728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4309a6fd-b4b0-44f5-8e92-3bb2a980cd2e", "AQAAAAEAACcQAAAAEJVzz/wlKeb+snlrTY/9KO/kAkrTkzBKJEDbFyh4EtLlAwAajRTpBLHPJSO9Xek66w==", "bc9dac2d-165b-4178-a687-3a16521ddd05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3555f575-c26b-4b61-846b-b90272e5a93a", "AQAAAAEAACcQAAAAEE0H6MwXl8ye7VvoIcwo/nN3TZdoX/qIVVvV3GZtBZQWktf1y9qXmmZFC+0EonVVAg==", "ac0256c6-655d-43c2-931b-15d9c8cbadf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc00eacf-281e-447c-96dc-b830a9f974ec", "AQAAAAEAACcQAAAAEFZy1/fgGs7VN+5iPc2+mZLe8oleRcb0tBBi9JnmWp+qnM3fVzxGpr8eKem79cINGA==", "cbff16ac-61f1-4136-bf00-c5ec5601dbb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fab8aac3-5a59-4051-b797-f661ff8e4474", "AQAAAAEAACcQAAAAENl2oT/4pnQbraARPPLShMsJ7d/fnHA48mBch5nobVYxBciSlpmiGeY/2aTfL7s1vA==", "fbf434d2-ddd8-45a1-996a-3cd64d93b3fc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5bac02b2-ece6-4a27-b48e-9fb67b472c4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ec157a9a-f07d-40b4-b2a2-c56eab98b86b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f09d055f-8076-460d-a27c-d45adff0fb55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "79b6721a-1d58-49c1-a557-180dc17b0dbf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92f7a269-2f05-4118-8d98-275a936de17d", "AQAAAAEAACcQAAAAEGwvB6i/1Mh+pVtti9ZE9JDMB3iJif4tmXD1m21xdheuk/DHs5l+B8eW13tsXvaFHQ==", "d108f516-d6cc-4a01-ba0b-556b17c8607a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015923a1-4a7e-40c8-9fe3-93f74680b975", "AQAAAAEAACcQAAAAEJJAl0PMUSnkmPlFRWq7M/YBwgCQ3YROnAo5KysmAIGgZfw0j48uq+Fx9aTSnBd0Pw==", "6d27abda-73c4-4427-a30a-a1de280a73be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a58b2ebb-94bb-44e0-8e36-2c5870561756", "AQAAAAEAACcQAAAAEBgL/u0Ru3pIwkP+9kuPjWtYJUhRPffM2kxZocJ1S/fgDNuwwcGl2zeyMsb0fZHe+Q==", "c9baebdc-3316-4da4-a511-d5ae9bb090ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee328198-0384-4325-817b-8872a9849f68", "AQAAAAEAACcQAAAAELHtqN9Gr+hA8l/7yYdF9cCI12/oeCpe41dRDdvmztw74hSH8znRlwI9WSTEW1w1pg==", "192b3264-b295-4cec-b288-b5f9b57b9ea9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07d274cd-d41f-47dd-9c5c-01e71eb78eb3", "AQAAAAEAACcQAAAAEDR6MBPUMotGbcLFV2jQbu4SWTDyEZbn+iHUim/PMAkD+sobXJ6RTkbFo6Zo3zUtsg==", "2cd36601-346d-413e-8f96-f32de35db18d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62e31d19-05fa-47c6-a7ab-08a00f3dd4cb", "AQAAAAEAACcQAAAAEMLFn57rIV0Rqknw6Fan+v27z0/tzjhJlTx6+2DfxOa3zcOwqwJmAojfBJ21FnfCbQ==", "859c51d9-3ac2-411f-8209-63212b7dd517" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec63c73d-5690-4e1d-acaf-95a3d4bb24d9", "AQAAAAEAACcQAAAAEH5xK0SEA+bMvSIl5U3vCXAioXuSmO9Q3QgyDFZbaH5hh4b7ZtLbbZAF0XB2xzLVVQ==", "529f4c17-293d-4534-935c-6023fe4872c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "550e2439-28be-4586-a1f3-ce6020d34bc4", "AQAAAAEAACcQAAAAEHqC/i2LgyD9WQyZ6yK4I75yQedwhzZReWZ0NKktMllQDTIoHlDb6xhugQEor5H5iA==", "a5ea71d1-add9-4474-94e9-aca5414c1760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d5b4ff-7037-494f-b457-c0d0d7251609", "AQAAAAEAACcQAAAAEH5z9LeT/A/CGhjc+oBUByHFKC8bVcdIWaZ6RY1nLvsHuf8f20AB74H+ghUvILiaVQ==", "a458c12a-d550-424d-a8ae-6f1f3a91894c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad57ac7-3883-4222-aaf0-4e4decbfe451", "AQAAAAEAACcQAAAAEHOOKIrF18UL/7GkV4QwolYL45FkB5WynC/2wcvskp0fxPKLcigS+tSvu5bQt4iYbw==", "35e25363-b66e-43fb-a5d0-767dd4659d6b" });
        }
    }
}
