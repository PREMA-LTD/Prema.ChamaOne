using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class updateddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contribution_Wards_fk_member_id",
                table: "Contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_Contribution_contribution_status_fk_contribution_status_id",
                table: "Contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_Contribution_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contribution",
                table: "Contribution");

            migrationBuilder.RenameTable(
                name: "Contribution",
                newName: "contribution");

            migrationBuilder.RenameIndex(
                name: "IX_Contribution_fk_member_id",
                table: "contribution",
                newName: "IX_contribution_fk_member_id");

            migrationBuilder.RenameIndex(
                name: "IX_Contribution_fk_contribution_status_id",
                table: "contribution",
                newName: "IX_contribution_fk_contribution_status_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contribution",
                table: "contribution",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_Wards_fk_member_id",
                table: "contribution",
                column: "fk_member_id",
                principalTable: "Wards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_contribution_status_fk_contribution_status_id",
                table: "contribution",
                column: "fk_contribution_status_id",
                principalTable: "contribution_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_contribution_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "contribution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contribution_Wards_fk_member_id",
                table: "contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_contribution_contribution_status_fk_contribution_status_id",
                table: "contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_contribution_fk_transaction_entity_id",
                table: "transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contribution",
                table: "contribution");

            migrationBuilder.RenameTable(
                name: "contribution",
                newName: "Contribution");

            migrationBuilder.RenameIndex(
                name: "IX_contribution_fk_member_id",
                table: "Contribution",
                newName: "IX_Contribution_fk_member_id");

            migrationBuilder.RenameIndex(
                name: "IX_contribution_fk_contribution_status_id",
                table: "Contribution",
                newName: "IX_Contribution_fk_contribution_status_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contribution",
                table: "Contribution",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contribution_Wards_fk_member_id",
                table: "Contribution",
                column: "fk_member_id",
                principalTable: "Wards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contribution_contribution_status_fk_contribution_status_id",
                table: "Contribution",
                column: "fk_contribution_status_id",
                principalTable: "contribution_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_Contribution_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id",
                principalTable: "Contribution",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
