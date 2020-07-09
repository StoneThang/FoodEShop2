using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodEShopSolution.Data.Migrations
{
    public partial class fix_stock_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Products",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3ba80d8a-1465-4ea0-ba75-39f73da12ea7"),
                column: "ConcurrencyStamp",
                value: "2df6d539-5844-4ab0-aff8-fb20c1488e32");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("130d34e0-7b45-4b7c-8fb1-718c765402aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9547f21-5b85-4f2e-9002-b701398934f8", "AQAAAAEAACcQAAAAEJcGPaui988yy23oKYOAsgVAdsRj0PPs7gDR/NJm3Ey02tSQGuN8FAkaBcw3bn3vng==" });

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
                value: new DateTime(2020, 7, 2, 21, 9, 36, 611, DateTimeKind.Local).AddTicks(8530));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3ba80d8a-1465-4ea0-ba75-39f73da12ea7"),
                column: "ConcurrencyStamp",
                value: "578d9ed4-4b6f-4f13-a7d7-4cb7978d30d3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("130d34e0-7b45-4b7c-8fb1-718c765402aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a15dd31-71ad-4206-bc75-15a2dd110302", "AQAAAAEAACcQAAAAEMlzDQAIzjTia430yEGQdBOQMXYEvoHSudLx9316gedFFPXhqT0zPeaAT3uZfJQoqw==" });

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
                columns: new[] { "DateCreated", "Stock", "ViewCount" },
                values: new object[] { new DateTime(2020, 6, 30, 22, 57, 39, 50, DateTimeKind.Local).AddTicks(4720), 1, 1 });
        }
    }
}
