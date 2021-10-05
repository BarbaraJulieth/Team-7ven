using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguiNutri.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoBasicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoBasicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosDatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Paciente = table.Column<int>(type: "int", nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaloriasConsumi = table.Column<double>(type: "float", nullable: false),
                    ProteinaConsumi = table.Column<double>(type: "float", nullable: false),
                    CarbohidratosConsumi = table.Column<double>(type: "float", nullable: false),
                    GrasaConsumi = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    MedidasAntropometricas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosDatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeguimientosNutri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNutricionista = table.Column<int>(type: "int", nullable: false),
                    IdCoach = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    SugerenciasCuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoricoBasicoPacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientosNutri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeguimientosNutri_HistoricoBasicos_HistoricoBasicoPacienteId",
                        column: x => x.HistoricoBasicoPacienteId,
                        principalTable: "HistoricoBasicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricosDatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRegistro = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    SeguimientoNutricionalPacienteId = table.Column<int>(type: "int", nullable: true),
                    RegistroId = table.Column<int>(type: "int", nullable: true),
                    HistoricoBasicoPacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricosDatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricosDatos_HistoricoBasicos_HistoricoBasicoPacienteId",
                        column: x => x.HistoricoBasicoPacienteId,
                        principalTable: "HistoricoBasicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricosDatos_RegistrosDatos_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "RegistrosDatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricosDatos_SeguimientosNutri_SeguimientoNutricionalPacienteId",
                        column: x => x.SeguimientoNutricionalPacienteId,
                        principalTable: "SeguimientosNutri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNutricionista = table.Column<int>(type: "int", nullable: true),
                    IdPaciente = table.Column<int>(type: "int", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachAsignadoPacienteId = table.Column<int>(type: "int", nullable: true),
                    NutricionistaAsignadoPacienteId = table.Column<int>(type: "int", nullable: true),
                    RegistroDatosPacienteId = table.Column<int>(type: "int", nullable: true),
                    SeguimientoNutrisPacienteId = table.Column<int>(type: "int", nullable: true),
                    HistoricoBasicoPacienteId = table.Column<int>(type: "int", nullable: true),
                    HistoricoDatosPacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_HistoricoBasicos_HistoricoBasicoPacienteId",
                        column: x => x.HistoricoBasicoPacienteId,
                        principalTable: "HistoricoBasicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_HistoricosDatos_HistoricoDatosPacienteId",
                        column: x => x.HistoricoDatosPacienteId,
                        principalTable: "HistoricosDatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_CoachAsignadoPacienteId",
                        column: x => x.CoachAsignadoPacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_NutricionistaAsignadoPacienteId",
                        column: x => x.NutricionistaAsignadoPacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_RegistrosDatos_RegistroDatosPacienteId",
                        column: x => x.RegistroDatosPacienteId,
                        principalTable: "RegistrosDatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_SeguimientosNutri_SeguimientoNutrisPacienteId",
                        column: x => x.SeguimientoNutrisPacienteId,
                        principalTable: "SeguimientosNutri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosDatos_HistoricoBasicoPacienteId",
                table: "HistoricosDatos",
                column: "HistoricoBasicoPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosDatos_RegistroId",
                table: "HistoricosDatos",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosDatos_SeguimientoNutricionalPacienteId",
                table: "HistoricosDatos",
                column: "SeguimientoNutricionalPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CoachAsignadoPacienteId",
                table: "Personas",
                column: "CoachAsignadoPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoricoBasicoPacienteId",
                table: "Personas",
                column: "HistoricoBasicoPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoricoDatosPacienteId",
                table: "Personas",
                column: "HistoricoDatosPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NutricionistaAsignadoPacienteId",
                table: "Personas",
                column: "NutricionistaAsignadoPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RegistroDatosPacienteId",
                table: "Personas",
                column: "RegistroDatosPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SeguimientoNutrisPacienteId",
                table: "Personas",
                column: "SeguimientoNutrisPacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosNutri_HistoricoBasicoPacienteId",
                table: "SeguimientosNutri",
                column: "HistoricoBasicoPacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "HistoricosDatos");

            migrationBuilder.DropTable(
                name: "RegistrosDatos");

            migrationBuilder.DropTable(
                name: "SeguimientosNutri");

            migrationBuilder.DropTable(
                name: "HistoricoBasicos");
        }
    }
}
