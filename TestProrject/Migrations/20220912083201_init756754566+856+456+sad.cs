using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProrject.Migrations
{
    public partial class init756754566856456sad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PPicture",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PPicture",
                table: "Products");
        }
    }
}
