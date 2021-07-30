using Microsoft.EntityFrameworkCore.Migrations;

namespace BrightwayBooking.Migrations
{
    public partial class AddCountrySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Country",
                columns: new[] { "Id", "CurrencyCode", "Name" },
                values: new object[,]
                {
                    { 1, "SGD", "Singapore" },
                    { 15, "IDR", "Indonesia" },
                    { 14, "MXN", "Mexico" },
                    { 13, "NZD", "New Zealand" },
                    { 12, "RUB", "Russia" },
                    { 11, "GBP", "Great Britain" },
                    { 10, "DKK", "Denmark" },
                    { 16, "TWD", "Taiwan" },
                    { 9, "INR", "India" },
                    { 7, "CNH", "China" },
                    { 6, "JPY", "Japan" },
                    { 5, "AUD", "Australian" },
                    { 4, "USD", "United States" },
                    { 3, "EUR", "Europe" },
                    { 2, "MYR", "Malaysia" },
                    { 8, "CAD", "Canada" },
                    { 17, "THB", "Thailand" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
