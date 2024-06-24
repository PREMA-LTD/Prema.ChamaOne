using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "county",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_county", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "member_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member_type", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_entity_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_entity_type", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_type", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "subcounty",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_county_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subcounty", x => x.id);
                    table.ForeignKey(
                        name: "FK_subcounty_county_fk_county_id",
                        column: x => x.fk_county_id,
                        principalTable: "county",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ward",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_subcounty_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ward", x => x.id);
                    table.ForeignKey(
                        name: "FK_ward_subcounty_fk_subcounty_id",
                        column: x => x.fk_subcounty_id,
                        principalTable: "subcounty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    other_names = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_of_birth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    national_id_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fk_residence_location_id = table.Column<int>(type: "int", nullable: false),
                    fk_gender_id = table.Column<int>(type: "int", nullable: false),
                    fk_member_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wards_gender_fk_gender_id",
                        column: x => x.fk_gender_id,
                        principalTable: "gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wards_member_type_fk_member_type_id",
                        column: x => x.fk_member_type_id,
                        principalTable: "member_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wards_ward_fk_residence_location_id",
                        column: x => x.fk_residence_location_id,
                        principalTable: "ward",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contribution",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    penalty = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    fk_member_id = table.Column<int>(type: "int", nullable: false),
                    fk_contribution_status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribution", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contribution_Wards_fk_member_id",
                        column: x => x.fk_member_id,
                        principalTable: "Wards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contribution_contribution_status_fk_contribution_status_id",
                        column: x => x.fk_contribution_status_id,
                        principalTable: "contribution_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "loan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    principal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    interest_rate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    interest = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    penalty = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    fk_member_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loan", x => x.id);
                    table.ForeignKey(
                        name: "FK_loan_Wards_fk_member_id",
                        column: x => x.fk_member_id,
                        principalTable: "Wards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date_of_transaction = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fk_transaction_type_id = table.Column<int>(type: "int", nullable: false),
                    fk_transaction_entity_type_id = table.Column<int>(type: "int", nullable: false),
                    fk_transaction_entity_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_transaction_Contribution_fk_transaction_entity_id",
                        column: x => x.fk_transaction_entity_id,
                        principalTable: "Contribution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_loan_fk_transaction_entity_id",
                        column: x => x.fk_transaction_entity_id,
                        principalTable: "loan",
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
                name: "IX_Contribution_fk_contribution_status_id",
                table: "Contribution",
                column: "fk_contribution_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contribution_fk_member_id",
                table: "Contribution",
                column: "fk_member_id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_fk_gender_id",
                table: "Wards",
                column: "fk_gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_fk_member_type_id",
                table: "Wards",
                column: "fk_member_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_fk_residence_location_id",
                table: "Wards",
                column: "fk_residence_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_loan_fk_member_id",
                table: "loan",
                column: "fk_member_id");

            migrationBuilder.CreateIndex(
                name: "IX_subcounty_fk_county_id",
                table: "subcounty",
                column: "fk_county_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_fk_transaction_entity_id",
                table: "transaction",
                column: "fk_transaction_entity_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_fk_transaction_entity_type_id",
                table: "transaction",
                column: "fk_transaction_entity_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_fk_transaction_type_id",
                table: "transaction",
                column: "fk_transaction_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ward_fk_subcounty_id",
                table: "ward",
                column: "fk_subcounty_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.DropTable(
                name: "Contribution");

            migrationBuilder.DropTable(
                name: "loan");

            migrationBuilder.DropTable(
                name: "transaction_entity_type");

            migrationBuilder.DropTable(
                name: "transaction_type");

            migrationBuilder.DropTable(
                name: "contribution_status");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "member_type");

            migrationBuilder.DropTable(
                name: "ward");

            migrationBuilder.DropTable(
                name: "subcounty");

            migrationBuilder.DropTable(
                name: "county");
        }
    }
}
