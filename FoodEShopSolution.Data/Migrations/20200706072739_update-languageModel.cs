using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodEShopSolution.Data.Migrations
{
    public partial class updatelanguageModel : Migration
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
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Languages");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "ProductTranslations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "Languages",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "CategoryTranslations",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldUnicode: false,
                oldMaxLength: 5);

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

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LanguageId",
                value: "vi-VN");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: "en-US");

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
                keyColumn: "LanguageId",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: "vi-VN");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Languages");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "ProductTranslations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "CategoryTranslations",
                type: "int",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Key", "Name" },
                values: new object[,]
                {
                    { 1, true, "vi-VN", "Tieng viet" },
                    { 2, false, "en-US", "English" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 3, 14, 55, 32, 560, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: 2);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
