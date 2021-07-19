using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaMedica.Migrations
{
    public partial class ListaConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "TBConsulta");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "TBConsulta",
                newName: "DataHorario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataHorario",
                table: "TBConsulta",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Horario",
                table: "TBConsulta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
