using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaMedica.Migrations
{
    public partial class HorarioDataConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataHorario",
                table: "TBConsulta",
                newName: "Horario");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "TBConsulta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "TBConsulta");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "TBConsulta",
                newName: "DataHorario");
        }
    }
}
