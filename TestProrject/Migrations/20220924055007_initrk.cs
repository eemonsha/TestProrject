using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProrject.Migrations
{
    public partial class initrk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartID",
                table: "Courses");
        }
    }
}
