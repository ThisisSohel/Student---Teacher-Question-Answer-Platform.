using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Teacher_Student_platform.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57f45334-7b8f-4fb5-9330-e209baff93b1", null, "student", "student" },
                    { "9159b4d4-a369-4813-83e9-f603dc144713", null, "teacher", "teacher" },
                    { "e0381a11-3a45-4dee-9466-8887c455daf3", null, "moderator", "moderator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57f45334-7b8f-4fb5-9330-e209baff93b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9159b4d4-a369-4813-83e9-f603dc144713");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0381a11-3a45-4dee-9466-8887c455daf3");
        }
    }
}
