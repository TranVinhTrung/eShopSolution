using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f35d00e-6ef3-435e-9799-f374dce8f54a"),
                column: "ConcurrencyStamp",
                value: "a521834f-3102-4b5d-9eab-8beb6c8a278b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1de6536a-ed8d-4337-b12b-5dcff625548f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b62a829-3c61-4b5c-94f4-9ec757e74379", "AQAAAAEAACcQAAAAEIiiOFwrhOUsBb8NZoGtewrBhWBResg3pFCDBZ9S4zpXqkCsxUJR1hXe0c2PuP+szg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 1, 30, 15, 48, 34, 936, DateTimeKind.Local).AddTicks(612));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f35d00e-6ef3-435e-9799-f374dce8f54a"),
                column: "ConcurrencyStamp",
                value: "b13ee536-7706-46a5-87b8-5cd61f07071c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1de6536a-ed8d-4337-b12b-5dcff625548f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1b012c3-3d5c-4d83-a864-3f74c76d0a20", "AQAAAAEAACcQAAAAEBidK3WtOOnYkRmRZCAy02EMWgOmheFjNw0kb5+r/kL1T546OmLDsUInsQx6AQI2ww==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 1, 28, 15, 55, 56, 55, DateTimeKind.Local).AddTicks(7032));
        }
    }
}
