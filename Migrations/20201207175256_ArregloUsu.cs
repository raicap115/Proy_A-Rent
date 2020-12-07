﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Proy_A_Rent.Migrations
{
    public partial class ArregloUsu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "genero",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<char>(
                name: "genero",
                table: "Usuarios",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ');
        }
    }
}
