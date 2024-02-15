using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    public partial class fixesDeletedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sale_id_sales",
                table: "sales_lines");

            migrationBuilder.AddForeignKey(
                name: "fk_sale_id_sales",
                table: "sales_lines",
                column: "sale_id",
                principalTable: "sales",
                principalColumn: "sale_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sale_id_sales",
                table: "sales_lines");

            migrationBuilder.AddForeignKey(
                name: "fk_sale_id_sales",
                table: "sales_lines",
                column: "sale_id",
                principalTable: "sales",
                principalColumn: "sale_id");
        }
    }
}
