using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedcontact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contact",
                table: "member",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contact",
                table: "member");
        }
    }
}
