using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2019113001.Migrations
{
    public partial class p6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Storage",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Storage",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
