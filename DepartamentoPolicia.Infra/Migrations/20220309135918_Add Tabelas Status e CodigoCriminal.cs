using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartamentoPolicia.Infra.Migrations
{
    public partial class AddTabelasStatuseCodigoCriminal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodigosCriminais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Penalidade = table.Column<decimal>(nullable: false),
                    TempoPrisao = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    IdUsuarioCriacao = table.Column<int>(nullable: false),
                    IdUsuarioAlteracao = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigosCriminais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodigosCriminais_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CodigosCriminais_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodigosCriminais_StatusId",
                table: "CodigosCriminais",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CodigosCriminais_UsuarioId",
                table: "CodigosCriminais",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodigosCriminais");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
