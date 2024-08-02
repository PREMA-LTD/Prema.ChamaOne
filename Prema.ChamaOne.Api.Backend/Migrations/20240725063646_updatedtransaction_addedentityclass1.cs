using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedtransaction_addedentityclass1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "TransactionEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "TransactionEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
