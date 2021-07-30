using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrightwayBooking.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CurrencyCode = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Email = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    AmountPerDay = table.Column<decimal>(type: "decimal(22,0)", nullable: false),
                    TotalTripAmount = table.Column<decimal>(type: "decimal(22,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CountryId",
                schema: "dbo",
                table: "Invoice",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "dbo");
        }
    }
}
