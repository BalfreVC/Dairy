using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "CreationDate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 1, 2, 29, 53, 295, DateTimeKind.Local).AddTicks(9963), "Description 1", "Title 1" },
                    { 2, new DateTime(2024, 10, 1, 2, 29, 53, 296, DateTimeKind.Local).AddTicks(19), "Description 2", "Title 2" },
                    { 3, new DateTime(2024, 10, 1, 2, 29, 53, 296, DateTimeKind.Local).AddTicks(21), "Description 3", "Title 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
