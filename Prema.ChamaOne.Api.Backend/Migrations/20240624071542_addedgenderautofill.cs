using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedgenderautofill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "gender",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gender",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "gender",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
