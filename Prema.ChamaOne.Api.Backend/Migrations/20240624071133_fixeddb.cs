using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixeddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wards_gender_fk_gender_id",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_member_type_fk_member_type_id",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_ward_fk_residence_location_id",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_contribution_Wards_fk_member_id",
                table: "contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_loan_Wards_fk_member_id",
                table: "loan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wards",
                table: "Wards");

            migrationBuilder.RenameTable(
                name: "Wards",
                newName: "member");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_fk_residence_location_id",
                table: "member",
                newName: "IX_member_fk_residence_location_id");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_fk_member_type_id",
                table: "member",
                newName: "IX_member_fk_member_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_fk_gender_id",
                table: "member",
                newName: "IX_member_fk_gender_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_member",
                table: "member",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_member_fk_member_id",
                table: "contribution",
                column: "fk_member_id",
                principalTable: "member",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_loan_member_fk_member_id",
                table: "loan",
                column: "fk_member_id",
                principalTable: "member",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_member_gender_fk_gender_id",
                table: "member",
                column: "fk_gender_id",
                principalTable: "gender",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_member_member_type_fk_member_type_id",
                table: "member",
                column: "fk_member_type_id",
                principalTable: "member_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_member_ward_fk_residence_location_id",
                table: "member",
                column: "fk_residence_location_id",
                principalTable: "ward",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contribution_member_fk_member_id",
                table: "contribution");

            migrationBuilder.DropForeignKey(
                name: "FK_loan_member_fk_member_id",
                table: "loan");

            migrationBuilder.DropForeignKey(
                name: "FK_member_gender_fk_gender_id",
                table: "member");

            migrationBuilder.DropForeignKey(
                name: "FK_member_member_type_fk_member_type_id",
                table: "member");

            migrationBuilder.DropForeignKey(
                name: "FK_member_ward_fk_residence_location_id",
                table: "member");

            migrationBuilder.DropPrimaryKey(
                name: "PK_member",
                table: "member");

            migrationBuilder.RenameTable(
                name: "member",
                newName: "Wards");

            migrationBuilder.RenameIndex(
                name: "IX_member_fk_residence_location_id",
                table: "Wards",
                newName: "IX_Wards_fk_residence_location_id");

            migrationBuilder.RenameIndex(
                name: "IX_member_fk_member_type_id",
                table: "Wards",
                newName: "IX_Wards_fk_member_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_member_fk_gender_id",
                table: "Wards",
                newName: "IX_Wards_fk_gender_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wards",
                table: "Wards",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_gender_fk_gender_id",
                table: "Wards",
                column: "fk_gender_id",
                principalTable: "gender",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_member_type_fk_member_type_id",
                table: "Wards",
                column: "fk_member_type_id",
                principalTable: "member_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_ward_fk_residence_location_id",
                table: "Wards",
                column: "fk_residence_location_id",
                principalTable: "ward",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contribution_Wards_fk_member_id",
                table: "contribution",
                column: "fk_member_id",
                principalTable: "Wards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_loan_Wards_fk_member_id",
                table: "loan",
                column: "fk_member_id",
                principalTable: "Wards",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
