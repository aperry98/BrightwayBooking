using Microsoft.EntityFrameworkCore.Migrations;

namespace BrightwayBooking.Migrations
{
    public partial class UpdateInvoiceIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                schema: "dbo",
                table: "Invoice",
                newName: "InvoiceNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceNumber",
                schema: "dbo",
                table: "Invoice",
                newName: "InvoiceId");
        }
    }
}
