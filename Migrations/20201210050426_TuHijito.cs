using Microsoft.EntityFrameworkCore.Migrations;

namespace Proy_A_Rent.Migrations
{
    public partial class TuHijito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cant_autoid",
                table: "Bookings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_cant_autoid",
                table: "Bookings",
                column: "cant_autoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Autos_cant_autoid",
                table: "Bookings",
                column: "cant_autoid",
                principalTable: "Autos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Autos_cant_autoid",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_cant_autoid",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "cant_autoid",
                table: "Bookings");
        }
    }
}
