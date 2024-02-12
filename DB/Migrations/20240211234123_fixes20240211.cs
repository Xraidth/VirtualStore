using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    public partial class fixes20240211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_name",
                table: "sales");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "fk_user_id_users",
                table: "sales",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_user_id_users",
                table: "sales",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_id_users",
                table: "sales");

            migrationBuilder.DropIndex(
                name: "fk_user_id_users",
                table: "sales");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "sales");

            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "sales",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
