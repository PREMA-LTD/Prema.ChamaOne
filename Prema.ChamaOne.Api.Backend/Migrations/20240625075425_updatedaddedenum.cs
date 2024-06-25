using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedaddedenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contribution_contribution_status_fk_contribution_status_id",
                table: "contribution");

            migrationBuilder.DropTable(
                name: "contribution_status");

            migrationBuilder.RenameColumn(
                name: "fk_contribution_status_id",
                table: "contribution",
                newName: "fk_transaction_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_contribution_fk_contribution_status_id",
                table: "contribution",
                newName: "IX_contribution_fk_transaction_status_id");

            migrationBuilder.AddColumn<DateTime>(
                name: "date_due",
                table: "loan",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "fk_transaction_status_id",
                table: "loan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "transaction_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "transaction_status",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Paid" },
                    { 2, "Pending" },
                    { 3, "Overdue" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_loan_fk_transaction_status_id",
                table: "loan",
                column: "fk_transaction_status_id");

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_transaction_status_fk_transaction_status_id",
                table: "contribution",
                column: "fk_transaction_status_id",
                principalTable: "transaction_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_loan_transaction_status_fk_transaction_status_id",
                table: "loan",
                column: "fk_transaction_status_id",
                principalTable: "transaction_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contribution_transaction_status_fk_transaction_status_id",
                table: "contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_loan_transaction_status_fk_transaction_status_id",
                table: "loan");

            migrationBuilder.DropTable(
                name: "transaction_status");

            migrationBuilder.DropIndex(
                name: "IX_loan_fk_transaction_status_id",
                table: "loan");

            migrationBuilder.DropColumn(
                name: "date_due",
                table: "loan");

            migrationBuilder.DropColumn(
                name: "fk_transaction_status_id",
                table: "loan");

            migrationBuilder.RenameColumn(
                name: "fk_transaction_status_id",
                table: "contribution",
                newName: "fk_contribution_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_contribution_fk_transaction_status_id",
                table: "contribution",
                newName: "IX_contribution_fk_contribution_status_id");

            migrationBuilder.CreateTable(
                name: "contribution_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contribution_status", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "contribution_status",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Paid" },
                    { 2, "Pending" },
                    { 3, "Overdue" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_contribution_status_fk_contribution_status_id",
                table: "contribution",
                column: "fk_contribution_status_id",
                principalTable: "contribution_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
