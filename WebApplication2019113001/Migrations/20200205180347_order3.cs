using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2019113001.Migrations
{
    public partial class order3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentsStatus",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "PaymentsStatus",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }
    }
}
