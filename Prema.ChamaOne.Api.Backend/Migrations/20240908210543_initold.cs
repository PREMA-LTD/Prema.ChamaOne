using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class initold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.DropTable(
            //    name: "contribution");

            //migrationBuilder.CreateTable(
            //    name: "contribution",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        amount = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        balance = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        penalty = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        contribution_period = table.Column<DateOnly>(type: "date", nullable: false),
            //        fk_member_id = table.Column<int>(type: "int", nullable: false),
            //        fk_transaction_status_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_contribution", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_contribution_member_fk_member_id",
            //            column: x => x.fk_member_id,
            //            principalTable: "member",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_contribution_transaction_status_fk_transaction_status_id",
            //            column: x => x.fk_transaction_status_id,
            //            principalTable: "transaction_status",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");


            //migrationBuilder.DropTable(
            //    name: "loan");

            //migrationBuilder.CreateTable(
            //    name: "loan",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        principal = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        interest_rate = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
            //        interest = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        penalty = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
            //        date_due = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        fk_member_id = table.Column<int>(type: "int", nullable: false),
            //        fk_transaction_status_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_loan", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_loan_member_fk_member_id",
            //            column: x => x.fk_member_id,
            //            principalTable: "member",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_loan_transaction_status_fk_transaction_status_id",
            //            column: x => x.fk_transaction_status_id,
            //            principalTable: "transaction_status",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransactionEntity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_contribution_id = table.Column<int>(type: "int", nullable: false),
                    fk_loan_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionEntity", x => x.id);
                    table.ForeignKey(
                        name: "FK_TransactionEntity_contribution_fk_contribution_id",
                        column: x => x.fk_contribution_id,
                        principalTable: "contribution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionEntity_loan_fk_loan_id",
                        column: x => x.fk_loan_id,
                        principalTable: "loan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    date_of_record = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(14,2)", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reference = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fk_transaction_type_id = table.Column<int>(type: "int", nullable: false),
                    fk_transaction_entity_type_id = table.Column<int>(type: "int", nullable: false),
                    fk_transaction_entity_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_transaction_TransactionEntity_fk_transaction_entity_id",
                        column: x => x.fk_transaction_entity_id,
                        principalTable: "TransactionEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_transaction_entity_type_fk_transaction_entity_ty~",
                        column: x => x.fk_transaction_entity_type_id,
                        principalTable: "transaction_entity_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_transaction_type_fk_transaction_type_id",
                        column: x => x.fk_transaction_type_id,
                        principalTable: "transaction_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionEntity_fk_contribution_id",
                table: "TransactionEntity",
                column: "fk_contribution_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionEntity_fk_loan_id",
                table: "TransactionEntity",
                column: "fk_loan_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transaction_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sms_failure");

            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.DropTable(
                name: "sms_record");

            migrationBuilder.DropTable(
                name: "TransactionEntity");

            migrationBuilder.DropTable(
                name: "transaction_entity_type");

            migrationBuilder.DropTable(
                name: "transaction_type");

            migrationBuilder.DropTable(
                name: "contribution");

            migrationBuilder.DropTable(
                name: "loan");

            migrationBuilder.DropTable(
                name: "member");

            migrationBuilder.DropTable(
                name: "transaction_status");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "member_type");

            migrationBuilder.DropTable(
                name: "occupation");

            migrationBuilder.DropTable(
                name: "ward");

            migrationBuilder.DropTable(
                name: "subcounty");

            migrationBuilder.DropTable(
                name: "county");
        }
    }
}
