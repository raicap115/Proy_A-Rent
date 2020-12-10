using Microsoft.EntityFrameworkCore.Migrations;

namespace Proy_A_Rent.Migrations
{
    public partial class BookingsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "modelo",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "id_usuarioid",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modeloid",
                table: "Bookings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_id_usuarioid",
                table: "Bookings",
                column: "id_usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_modeloid",
                table: "Bookings",
                column: "modeloid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Usuarios_id_usuarioid",
                table: "Bookings",
                column: "id_usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Autos_modeloid",
                table: "Bookings",
                column: "modeloid",
                principalTable: "Autos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Usuarios_id_usuarioid",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Autos_modeloid",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_id_usuarioid",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_modeloid",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "id_usuarioid",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "modeloid",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "id_usuario",
                table: "Bookings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modelo",
                table: "Bookings",
                type: "text",
                nullable: true);
        }
    }
}
