using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Repository.Migrations
{
    public partial class addedPostPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 19, 7, 47, 700, DateTimeKind.Local).AddTicks(6243), "Blog Description", "1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 19, 7, 47, 700, DateTimeKind.Local).AddTicks(6253), "Blog Description", "2.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 19, 7, 47, 700, DateTimeKind.Local).AddTicks(6253), "Blog Description", "3.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 19, 7, 47, 700, DateTimeKind.Local).AddTicks(6254), "Blog Description", "4.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 54, 18, 527, DateTimeKind.Local).AddTicks(7453), null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 54, 18, 527, DateTimeKind.Local).AddTicks(7463), null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 54, 18, 527, DateTimeKind.Local).AddTicks(7464), null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ImagePath" },
                values: new object[] { new DateTime(2022, 8, 30, 18, 54, 18, 527, DateTimeKind.Local).AddTicks(7464), null, null });
        }
    }
}
