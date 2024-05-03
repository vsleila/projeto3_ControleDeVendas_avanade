using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniMundo.Migrations
{
    /// <inheritdoc />
    public partial class ClienteAddDois : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CPF",
                table: "NivelDeAcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nivel",
                table: "NivelDeAcesso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "NivelDeAcesso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "NivelDeAcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "NivelDeAcesso");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "NivelDeAcesso");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "NivelDeAcesso");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "NivelDeAcesso");
        }
    }
}
