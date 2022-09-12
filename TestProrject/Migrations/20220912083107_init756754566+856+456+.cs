using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProrject.Migrations
{
    public partial class init756754566856456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QRs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCode = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QrImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QrCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QrQty = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QRs");
        }
    }
}
