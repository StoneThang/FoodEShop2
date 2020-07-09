using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodEShopSolution.Data.Migrations
{
    public partial class updatelanguageModelv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: "vi-VN");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Languages",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3ba80d8a-1465-4ea0-ba75-39f73da12ea7"),
                column: "ConcurrencyStamp",
                value: "508897ca-ac1e-437d-b86f-fd954893c324");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("130d34e0-7b45-4b7c-8fb1-718c765402aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2e8087f-183e-407e-9a46-e8db075482f2", "AQAAAAEAACcQAAAAELTqBMqzlRtVzKmKrN7VW0SDlZm1R5v3AJ05kBAWJBQkCA8bxk07CbBf8v4BoW2DJw==" });

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

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tieng viet" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 6, 15, 20, 15, 644, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "Languages",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "LanguageId");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3ba80d8a-1465-4ea0-ba75-39f73da12ea7"),
                column: "ConcurrencyStamp",
                value: "7363b993-0faf-4db1-b4a6-c6b949b78b6b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("130d34e0-7b45-4b7c-8fb1-718c765402aa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6e4fa8f-4d1a-46b7-a0fc-9f64744c0f27", "AQAAAAEAACcQAAAAEDw5CCqbLzBNqbS8h0V+fkg7FPzMS4MQxPobopwNGCmOJZHy5A0B0adcJhFfhlRLPw==" });

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

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tieng viet" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 6, 14, 27, 37, 860, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTranslations_Languages_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
