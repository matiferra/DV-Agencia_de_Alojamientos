using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_alojamiento",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "id_alojamiento",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "id_alojamiento",
                table: "Cabania");

            migrationBuilder.DropColumn(
                name: "id_ciudad",
                table: "Alojamiento");

            migrationBuilder.DropColumn(
                name: "id_alojamiento",
                table: "Agencia");

            migrationBuilder.AddColumn<int>(
                name: "id_alojamientoid",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_usuarioid",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamientoid",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamientoid",
                table: "Cabania",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_ciudadid",
                table: "Alojamiento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamientoid",
                table: "Agencia",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_id_alojamientoid",
                table: "Reserva",
                column: "id_alojamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_id_usuarioid",
                table: "Reserva",
                column: "id_usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_id_alojamientoid",
                table: "Hotel",
                column: "id_alojamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Cabania_id_alojamientoid",
                table: "Cabania",
                column: "id_alojamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Alojamiento_id_ciudadid",
                table: "Alojamiento",
                column: "id_ciudadid");

            migrationBuilder.CreateIndex(
                name: "IX_Agencia_id_alojamientoid",
                table: "Agencia",
                column: "id_alojamientoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencia_Alojamiento_id_alojamientoid",
                table: "Agencia",
                column: "id_alojamientoid",
                principalTable: "Alojamiento",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alojamiento_Ciudades_id_ciudadid",
                table: "Alojamiento",
                column: "id_ciudadid",
                principalTable: "Ciudades",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cabania_Alojamiento_id_alojamientoid",
                table: "Cabania",
                column: "id_alojamientoid",
                principalTable: "Alojamiento",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Alojamiento_id_alojamientoid",
                table: "Hotel",
                column: "id_alojamientoid",
                principalTable: "Alojamiento",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Alojamiento_id_alojamientoid",
                table: "Reserva",
                column: "id_alojamientoid",
                principalTable: "Alojamiento",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuario_id_usuarioid",
                table: "Reserva",
                column: "id_usuarioid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencia_Alojamiento_id_alojamientoid",
                table: "Agencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Alojamiento_Ciudades_id_ciudadid",
                table: "Alojamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cabania_Alojamiento_id_alojamientoid",
                table: "Cabania");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Alojamiento_id_alojamientoid",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Alojamiento_id_alojamientoid",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuario_id_usuarioid",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_id_alojamientoid",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_id_usuarioid",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_id_alojamientoid",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Cabania_id_alojamientoid",
                table: "Cabania");

            migrationBuilder.DropIndex(
                name: "IX_Alojamiento_id_ciudadid",
                table: "Alojamiento");

            migrationBuilder.DropIndex(
                name: "IX_Agencia_id_alojamientoid",
                table: "Agencia");

            migrationBuilder.DropColumn(
                name: "id_alojamientoid",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "id_usuarioid",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "id_alojamientoid",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "id_alojamientoid",
                table: "Cabania");

            migrationBuilder.DropColumn(
                name: "id_ciudadid",
                table: "Alojamiento");

            migrationBuilder.DropColumn(
                name: "id_alojamientoid",
                table: "Agencia");

            migrationBuilder.AddColumn<int>(
                name: "id_alojamiento",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamiento",
                table: "Hotel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamiento",
                table: "Cabania",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_ciudad",
                table: "Alojamiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_alojamiento",
                table: "Agencia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
