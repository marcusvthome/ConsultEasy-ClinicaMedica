using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaMedica.Migrations
{
    public partial class InsereConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataHorarioConsulta",
                table: "TBConsulta",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Horario",
                table: "TBConsulta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "TBConsulta");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "TBConsulta",
                newName: "DataHorarioConsulta");
        }
    }
}
