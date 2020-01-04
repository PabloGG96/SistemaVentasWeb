using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasWeb.Migrations
{
    public partial class Nombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "DetalleDeProductos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "DetalleDeProductos");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
