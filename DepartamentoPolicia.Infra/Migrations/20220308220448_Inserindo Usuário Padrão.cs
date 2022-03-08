using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartamentoPolicia.Infra.Migrations
{
    public partial class InserindoUsuárioPadrão : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nome", "Senha" },
                values: new object[] { new Guid("8a2fee16-6b7c-4743-a3ec-d9b879d3a206"), "admin", "@dmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("8a2fee16-6b7c-4743-a3ec-d9b879d3a206"));
        }
    }
}
