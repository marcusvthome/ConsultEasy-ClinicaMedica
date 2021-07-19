using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaMedica.Migrations
{
    public partial class InsereMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBMedico_CRM",
                table: "TBMedico");

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "TBMedico",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBMedico_CRM",
                table: "TBMedico",
                column: "CRM",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBMedico_CRM",
                table: "TBMedico");

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "TBMedico",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_TBMedico_CRM",
                table: "TBMedico",
                column: "CRM",
                unique: true,
                filter: "[CRM] IS NOT NULL");
        }
    }
}
