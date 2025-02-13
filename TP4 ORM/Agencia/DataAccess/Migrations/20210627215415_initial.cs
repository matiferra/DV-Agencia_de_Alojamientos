﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esAdmin = table.Column<bool>(type: "bit", nullable: false),
                    bloqueado = table.Column<bool>(type: "bit", nullable: false),
                    intentosLogueo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

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
                    ciudadid = table.Column<int>(type: "int", nullable: true),
                    cantidad_de_habitaciones = table.Column<int>(type: "int", nullable: false),
                    precio_por_dia = table.Column<double>(type: "float", nullable: false),
                    precio_por_persona = table.Column<double>(type: "float", nullable: false),
                    cantidadDeBanios = table.Column<int>(type: "int", nullable: false),
                    esHotel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alojamiento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alojamiento_Ciudades_ciudadid",
                        column: x => x.ciudadid,
                        principalTable: "Ciudades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_alojamientoid = table.Column<int>(type: "int", nullable: true),
                    cantAlojamientos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_Agencia_Alojamiento_id_alojamientoid",
                        column: x => x.id_alojamientoid,
                        principalTable: "Alojamiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contador = table.Column<int>(type: "int", nullable: false),
                    FDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_alojamientoid = table.Column<int>(type: "int", nullable: true),
                    id_usuarioid = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reserva_Alojamiento_id_alojamientoid",
                        column: x => x.id_alojamientoid,
                        principalTable: "Alojamiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_id_usuarioid",
                        column: x => x.id_usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgenciaManager",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuarioid = table.Column<int>(type: "int", nullable: true),
                    id_reservaid = table.Column<int>(type: "int", nullable: true),
                    id_agenciaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgenciaManager", x => x.id);
                    table.ForeignKey(
                        name: "FK_AgenciaManager_Agencia_id_agenciaid",
                        column: x => x.id_agenciaid,
                        principalTable: "Agencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgenciaManager_Reserva_id_reservaid",
                        column: x => x.id_reservaid,
                        principalTable: "Reserva",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgenciaManager_Usuario_id_usuarioid",
                        column: x => x.id_usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "id", "nombre" },
                values: new object[,]
                {
                    { 1, "buenos aires" },
                    { 2, "rio negro" },
                    { 3, "la plata" },
                    { 4, "bariloche" },
                    { 5, "lujan" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id", "DNI", "bloqueado", "esAdmin", "intentosLogueo", "mail", "nombre", "pass" },
                values: new object[,]
                {
                    { 1, 0, false, true, 0, "soporte@gmail.com", "fede", "123" },
                    { 2, 111111, false, false, 0, "soporte@gmail.com", "gianpool", "123" },
                    { 3, 222222, false, false, 0, "soporte@gmail.com", "matiferra", "123" },
                    { 4, 333333, true, false, 0, "soporte@gmail.com", "gabo", "123" },
                    { 5, 444444, false, true, 0, "soporte@gmail.com", "dino", "123" },
                    { 6, 555555, false, false, 0, "soporte@gmail.com", "fran", "123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agencia_id_alojamientoid",
                table: "Agencia",
                column: "id_alojamientoid");

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

            migrationBuilder.CreateIndex(
                name: "IX_Alojamiento_ciudadid",
                table: "Alojamiento",
                column: "ciudadid");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_id_alojamientoid",
                table: "Reserva",
                column: "id_alojamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_id_usuarioid",
                table: "Reserva",
                column: "id_usuarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgenciaManager");

            migrationBuilder.DropTable(
                name: "Agencia");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Alojamiento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ciudades");
        }
    }
}
