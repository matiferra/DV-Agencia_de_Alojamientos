using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alojamiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estrellas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidadDePersonas = table.Column<int>(type: "int", nullable: false),
                    tv = table.Column<bool>(type: "bit", nullable: false),
                    id_ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad_de_habitaciones = table.Column<int>(type: "int", nullable: false),
                    precio_por_dia = table.Column<double>(type: "float", nullable: false),
                    precio_por_persona = table.Column<double>(type: "float", nullable: false),
                    cantidadDeBanios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alojamiento", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alojamiento");
        }
    }
}
