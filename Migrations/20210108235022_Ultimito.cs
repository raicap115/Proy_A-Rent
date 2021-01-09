using Microsoft.EntityFrameworkCore.Migrations;

namespace Proy_A_Rent.Migrations
{
    public partial class Ultimito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "capacidad",
                table: "Autos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capacidad",
                table: "Autos");
        }
    }
}
