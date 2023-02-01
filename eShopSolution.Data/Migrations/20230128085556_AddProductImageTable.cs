using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 24, 19, 9, 19, 487, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DeteCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 24, 19, 9, 19, 487, DateTimeKind.Local).AddTicks(6500),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f35d00e-6ef3-435e-9799-f374dce8f54a"),
                column: "ConcurrencyStamp",
                value: "b6987c39-9d67-448d-b63f-9f8f68b71c45");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1de6536a-ed8d-4337-b12b-5dcff625548f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7110a341-e428-4591-a468-ec45e9dff00a", "AQAAAAEAACcQAAAAEIf7HoaweGSs8hTLo14TiYY43+HljNnVI3cQ/SVbtGtbgL95j/6jcqaKO71Lv9AC6w==" });

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
                value: new DateTime(2023, 1, 24, 19, 9, 19, 503, DateTimeKind.Local).AddTicks(9215));
        }
    }
}
