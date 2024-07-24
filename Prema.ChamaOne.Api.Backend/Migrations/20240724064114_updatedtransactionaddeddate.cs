using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedtransactionaddeddate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date_of_transaction",
                table: "transaction",
                newName: "date_of_record");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "transaction",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "transaction");

            migrationBuilder.RenameColumn(
                name: "date_of_record",
                table: "transaction",
                newName: "date_of_transaction");
        }
    }
}
