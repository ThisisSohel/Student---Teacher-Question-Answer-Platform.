using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Teacher_Student_platform.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40f6c66a-da16-41ee-b7ee-40a89a496a32", null, "moderator", null },
                    { "db2d2b6e-09d2-4303-a218-63f656933d65", null, "teacher", "moderator" },
                    { "eece73d8-46af-4499-9fdf-1de15c308548", null, "student", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f6c66a-da16-41ee-b7ee-40a89a496a32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2d2b6e-09d2-4303-a218-63f656933d65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eece73d8-46af-4499-9fdf-1de15c308548");
        }
    }
}
