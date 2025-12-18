using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace latihan2.Migrations
{
    /// <inheritdoc />
    public partial class TambahSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 30, "gan@gmail.com", "Gan" },
                    { 2, 25, "zidan@gmail.com", "Zidan" },
                    { 3, 24, "tedi@gmail.com", "Tedi" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "StudentId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Pemrograman C#" },
                    { 2, 1, "Pemrograman Java" },
                    { 3, 2, "Pemrograman Python" },
                    { 4, 3, "Pemrograman PHP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
