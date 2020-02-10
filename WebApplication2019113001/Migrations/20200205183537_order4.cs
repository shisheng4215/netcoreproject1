using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2019113001.Migrations
{
    public partial class order4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_ProductVariants_ProductVariantProductId_ProductVa~",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductVariantProductId_ProductVariantColourId_Pr~",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ProductVariantColourId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ProductVariantProductId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ProductVariantStorageId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "OrderItem",
                newName: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId_ColourId_StorageId",
                table: "OrderItem",
                columns: new[] { "ProductId", "ColourId", "StorageId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_ProductVariants_ProductId_ColourId_StorageId",
                table: "OrderItem",
                columns: new[] { "ProductId", "ColourId", "StorageId" },
                principalTable: "ProductVariants",
                principalColumns: new[] { "ProductId", "ColourId", "StorageId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_ProductVariants_ProductId_ColourId_StorageId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId_ColourId_StorageId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "ColourId",
                table: "OrderItem",
                newName: "ColorId");

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantColourId",
                table: "OrderItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantProductId",
                table: "OrderItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantStorageId",
                table: "OrderItem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductVariantProductId_ProductVariantColourId_Pr~",
                table: "OrderItem",
                columns: new[] { "ProductVariantProductId", "ProductVariantColourId", "ProductVariantStorageId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_ProductVariants_ProductVariantProductId_ProductVa~",
                table: "OrderItem",
                columns: new[] { "ProductVariantProductId", "ProductVariantColourId", "ProductVariantStorageId" },
                principalTable: "ProductVariants",
                principalColumns: new[] { "ProductId", "ColourId", "StorageId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
