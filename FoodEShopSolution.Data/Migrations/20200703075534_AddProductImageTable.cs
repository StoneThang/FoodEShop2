using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodEShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DateCreated = table.Column<DateTime>(nullable: false),
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
                keyValue: new Guid("3ba80d8a-1465-4ea0-ba75-39f73da12ea7"),
                column: "ConcurrencyStamp",
                value: "7ba3bb4e-0db1-461d-9cc2-11662a2deb4b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("130d34e0-7b45-4b7c-8fb1-718c765402aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "833abbea-d14a-4c5b-a1bc-7dc5d8bde367", "AQAAAAEAACcQAAAAEE2268waew0Ke1iHFLONf9h9rk5gu5fNTRetRZsGwGM6yHomQVtFPNzbNkE8BhVMAw==" });

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
                value: new DateTime(2020, 7, 3, 14, 55, 32, 560, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Products_ProductId",
                table: "ProductTranslations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Products_ProductId",
                table: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations");

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
    }
}
