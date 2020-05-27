using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_First_Poject.Migrations
{
    public partial class Version101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Phones",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
