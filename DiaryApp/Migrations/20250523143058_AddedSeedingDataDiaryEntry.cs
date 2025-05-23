using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "CreatedAt", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Went swimming with James", "Went swimming" },
                    { 2, new DateTime(2025, 5, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Went to the gym with James", "Went to the gym" },
                    { 3, new DateTime(2025, 5, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Went to the movies with James", "Went to the movies" },
                    { 4, new DateTime(2025, 5, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Went to the park with Mary", "Went to the park" }
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

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
