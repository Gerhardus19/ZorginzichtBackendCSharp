using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZorginzichtBackend.Migrations
{
    /// <inheritdoc />
    public partial class Policies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyNr = table.Column<int>(type: "int", nullable: false),
                    PolicyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Insurance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "ID", "Costs", "Insurance", "PolicyName", "PolicyNr" },
                values: new object[] { 1, 120.5f, "My insurance", "Interpolis 1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");
        }
    }
}
