using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_contribution_fk_contribution_id",
                table: "transaction_entity");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_loan_fk_loan_id",
                table: "transaction_entity");

            migrationBuilder.AlterColumn<int>(
                name: "fk_loan_id",
                table: "transaction_entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "fk_contribution_id",
                table: "transaction_entity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entity_contribution_fk_contribution_id",
                table: "transaction_entity",
                column: "fk_contribution_id",
                principalTable: "contribution",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entity_loan_fk_loan_id",
                table: "transaction_entity",
                column: "fk_loan_id",
                principalTable: "loan",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_contribution_fk_contribution_id",
                table: "transaction_entity");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_loan_fk_loan_id",
                table: "transaction_entity");

            migrationBuilder.AlterColumn<int>(
                name: "fk_loan_id",
                table: "transaction_entity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fk_contribution_id",
                table: "transaction_entity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entity_contribution_fk_contribution_id",
                table: "transaction_entity",
                column: "fk_contribution_id",
                principalTable: "contribution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entity_loan_fk_loan_id",
                table: "transaction_entity",
                column: "fk_loan_id",
                principalTable: "loan",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
