using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class correccion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_agencia",
                table: "AgenciaManager");

            migrationBuilder.DropColumn(
                name: "id_reserva",
                table: "AgenciaManager");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "AgenciaManager");

            migrationBuilder.AddColumn<int>(
                name: "id_agenciaid",
                table: "AgenciaManager",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_reservaid",
                table: "AgenciaManager",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_usuarioid",
                table: "AgenciaManager",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AgenciaManager_id_agenciaid",
                table: "AgenciaManager",
                column: "id_agenciaid");

            migrationBuilder.CreateIndex(
                name: "IX_AgenciaManager_id_reservaid",
                table: "AgenciaManager",
                column: "id_reservaid");

            migrationBuilder.CreateIndex(
                name: "IX_AgenciaManager_id_usuarioid",
                table: "AgenciaManager",
                column: "id_usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_AgenciaManager_Agencia_id_agenciaid",
                table: "AgenciaManager",
                column: "id_agenciaid",
                principalTable: "Agencia",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgenciaManager_Reserva_id_reservaid",
                table: "AgenciaManager",
                column: "id_reservaid",
                principalTable: "Reserva",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AgenciaManager_Usuario_id_usuarioid",
                table: "AgenciaManager",
                column: "id_usuarioid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgenciaManager_Agencia_id_agenciaid",
                table: "AgenciaManager");

            migrationBuilder.DropForeignKey(
                name: "FK_AgenciaManager_Reserva_id_reservaid",
                table: "AgenciaManager");

            migrationBuilder.DropForeignKey(
                name: "FK_AgenciaManager_Usuario_id_usuarioid",
                table: "AgenciaManager");

            migrationBuilder.DropIndex(
                name: "IX_AgenciaManager_id_agenciaid",
                table: "AgenciaManager");

            migrationBuilder.DropIndex(
                name: "IX_AgenciaManager_id_reservaid",
                table: "AgenciaManager");

            migrationBuilder.DropIndex(
                name: "IX_AgenciaManager_id_usuarioid",
                table: "AgenciaManager");

            migrationBuilder.DropColumn(
                name: "id_agenciaid",
                table: "AgenciaManager");

            migrationBuilder.DropColumn(
                name: "id_reservaid",
                table: "AgenciaManager");

            migrationBuilder.DropColumn(
                name: "id_usuarioid",
                table: "AgenciaManager");

            migrationBuilder.AddColumn<int>(
                name: "id_agencia",
                table: "AgenciaManager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_reserva",
                table: "AgenciaManager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "AgenciaManager",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
