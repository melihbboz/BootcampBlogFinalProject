using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Repository.Migrations
{
    public partial class TableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostFeatures_Products_PostId",
                table: "PostFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Posts",
                newName: "IX_Posts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 35, 39, 386, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 35, 39, 386, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 35, 39, 386, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 35, 39, 386, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.AddForeignKey(
                name: "FK_PostFeatures_Posts_PostId",
                table: "PostFeatures",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostFeatures_Posts_PostId",
                table: "PostFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 19, 27, 828, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 19, 27, 828, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 19, 27, 828, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 29, 14, 19, 27, 828, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.AddForeignKey(
                name: "FK_PostFeatures_Products_PostId",
                table: "PostFeatures",
                column: "PostId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
