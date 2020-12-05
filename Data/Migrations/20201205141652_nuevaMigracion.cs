using Microsoft.EntityFrameworkCore.Migrations;

namespace Proy_A_Rent.Data.Migrations
{
    public partial class nuevaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autos",
                table: "Autos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "t_usuario");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "t_bookings)");

            migrationBuilder.RenameTable(
                name: "Autos",
                newName: "t_auto)");

            migrationBuilder.AddColumn<string>(
                name: "id_usuario",
                table: "t_bookings)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_usuario",
                table: "t_usuario",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_bookings)",
                table: "t_bookings)",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_auto)",
                table: "t_auto)",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_t_usuario",
                table: "t_usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_bookings)",
                table: "t_bookings)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_auto)",
                table: "t_auto)");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "t_bookings)");

            migrationBuilder.RenameTable(
                name: "t_usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "t_bookings)",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "t_auto)",
                newName: "Autos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autos",
                table: "Autos",
                column: "id");
        }
    }
}
