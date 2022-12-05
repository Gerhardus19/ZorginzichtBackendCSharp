using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZorginzichtBackend.Migrations
{
    /// <inheritdoc />
    public partial class CustomerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CustomerNumber", "Name", "PolicyID" },
                values: new object[] { 1, 1, "Robin", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
