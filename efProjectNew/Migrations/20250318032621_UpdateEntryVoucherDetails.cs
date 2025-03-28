using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efProjectNew.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntryVoucherDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntryVoucherDetails",
                columns: table => new
                {
                    ReferenceNumber = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryVoucherDetails", x => new { x.ReferenceNumber, x.ProductId });
                    table.ForeignKey(
                        name: "FK_EntryVoucherDetails_EntryVouchers_ReferenceNumber",
                        column: x => x.ReferenceNumber,
                        principalTable: "EntryVouchers",
                        principalColumn: "referenceNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryVoucherDetails_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntryVoucherDetails_ProductId",
                table: "EntryVoucherDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryVoucherDetails");
        }
    }
}
