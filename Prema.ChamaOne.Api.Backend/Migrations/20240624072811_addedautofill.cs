using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prema.ChamaOne.Api.Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedautofill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "contribution_status",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Paid" },
                    { 2, "Pending" },
                    { 3, "Overdue" }
                });

            migrationBuilder.InsertData(
                table: "member_type",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Member" },
                    { 2, "Director" },
                    { 3, "Deputy Director" },
                    { 4, "Secratary" },
                    { 5, "Deputy Secratary" },
                    { 6, "Treasurer" }
                });

            migrationBuilder.InsertData(
                table: "transaction_entity_type",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Contribution" },
                    { 2, "Loan" },
                    { 3, "Project" },
                    { 4, "Welfare" }
                });

            migrationBuilder.InsertData(
                table: "transaction_type",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Contribution Payment" },
                    { 2, "Loan Disbursement" },
                    { 3, "Loan Payment" },
                    { 4, "Project Expense" },
                    { 5, "Project Income" },
                    { 6, "Welfare Disbursement" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "contribution_status",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "contribution_status",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "contribution_status",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "member_type",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "transaction_entity_type",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transaction_entity_type",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transaction_entity_type",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transaction_entity_type",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "transaction_type",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
