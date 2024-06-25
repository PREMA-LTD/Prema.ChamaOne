using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedoccupation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "date_of_birth",
                table: "member",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<int>(
                name: "fk_occupation_id",
                table: "member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "occupation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_occupation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "occupation",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Student" },
                    { 2, "Employed" },
                    { 3, "Self Employed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_member_fk_occupation_id",
                table: "member",
                column: "fk_occupation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_member_occupation_fk_occupation_id",
                table: "member",
                column: "fk_occupation_id",
                principalTable: "occupation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_occupation_fk_occupation_id",
                table: "member");

            migrationBuilder.DropTable(
                name: "occupation");

            migrationBuilder.DropIndex(
                name: "IX_member_fk_occupation_id",
                table: "member");

            migrationBuilder.DropColumn(
                name: "fk_occupation_id",
                table: "member");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_of_birth",
                table: "member",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
