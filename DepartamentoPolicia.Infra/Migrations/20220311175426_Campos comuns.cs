using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartamentoPolicia.Infra.Migrations
{
    public partial class Camposcomuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "CodigosCriminais");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "CodigosCriminais");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Usuarios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CodigosCriminais",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CodigosCriminais",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "CodigosCriminais",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CodigosCriminais",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("8a2fee16-6b7c-4743-a3ec-d9b879d3a206"),
                column: "DateCreated",
                value: new DateTime(2022, 3, 11, 14, 54, 25, 776, DateTimeKind.Local).AddTicks(8151));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CodigosCriminais");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "CodigosCriminais");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CodigosCriminais");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CodigosCriminais",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "CodigosCriminais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "CodigosCriminais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
