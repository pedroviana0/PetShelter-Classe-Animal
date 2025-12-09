using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShelter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Porte = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HistoricoSaude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimalID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");
        }
    }
}
