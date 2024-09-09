using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionEntity_contribution_fk_contribution_id",
                table: "TransactionEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionEntity_loan_fk_loan_id",
                table: "TransactionEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionEntity",
                table: "TransactionEntity");

            migrationBuilder.RenameTable(
                name: "TransactionEntity",
                newName: "transaction_entity");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionEntity_fk_loan_id",
                table: "transaction_entity",
                newName: "IX_transaction_entity_fk_loan_id");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionEntity_fk_contribution_id",
                table: "transaction_entity",
                newName: "IX_transaction_entity_fk_contribution_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transaction_entity",
                table: "transaction_entity",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_transaction_entity_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "transaction_entity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_transaction_entity_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_contribution_fk_contribution_id",
                table: "transaction_entity");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entity_loan_fk_loan_id",
                table: "transaction_entity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transaction_entity",
                table: "transaction_entity");

            migrationBuilder.RenameTable(
                name: "transaction_entity",
                newName: "TransactionEntity");

            migrationBuilder.RenameIndex(
                name: "IX_transaction_entity_fk_loan_id",
                table: "TransactionEntity",
                newName: "IX_TransactionEntity_fk_loan_id");

            migrationBuilder.RenameIndex(
                name: "IX_transaction_entity_fk_contribution_id",
                table: "TransactionEntity",
                newName: "IX_TransactionEntity_fk_contribution_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionEntity",
                table: "TransactionEntity",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionEntity_contribution_fk_contribution_id",
                table: "TransactionEntity",
                column: "fk_contribution_id",
                principalTable: "contribution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionEntity_loan_fk_loan_id",
                table: "TransactionEntity",
                column: "fk_loan_id",
                principalTable: "loan",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "TransactionEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
