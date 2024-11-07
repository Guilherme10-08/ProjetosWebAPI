using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Farmacia.Migrations
{
    /// <inheritdoc />
    public partial class GerandoNovasTabelasAdicionandoCampoDescricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descricaoComprimido",
                table: "comprimido",
                type: "longtext",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "Ampolas",
                columns: table => new
                {
                    idAmpola = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeAmpola = table.Column<string>(type: "longtext", nullable: false),
                    precoAmpola = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stockAmpola = table.Column<int>(type: "int", nullable: false),
                    dataFabricoAmpola = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataExpiracaoAmpola = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    descricaoAmpola = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ampolas", x => x.idAmpola);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Soros",
                columns: table => new
                {
                    idSoro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeSoro = table.Column<string>(type: "longtext", nullable: false),
                    precoSoro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stockSoro = table.Column<int>(type: "int", nullable: false),
                    dataFabricoSoro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataExpiracaoSoro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    descricaoSoro = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soros", x => x.idSoro);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vitaminas",
                columns: table => new
                {
                    idVitamina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeVitamina = table.Column<string>(type: "longtext", nullable: false),
                    precoVitamina = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stockVitamina = table.Column<int>(type: "int", nullable: false),
                    dataFabricoVitamina = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataExpiracaoVitamina = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    descricaoVitamina = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitaminas", x => x.idVitamina);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Xaropes",
                columns: table => new
                {
                    idXarope = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeXarope = table.Column<string>(type: "longtext", nullable: false),
                    precoXarope = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stockXarope = table.Column<int>(type: "int", nullable: false),
                    dataFabricoXarope = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataExpiracaoXarope = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    descricaoXarope = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xaropes", x => x.idXarope);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ampolas");

            migrationBuilder.DropTable(
                name: "Soros");

            migrationBuilder.DropTable(
                name: "Vitaminas");

            migrationBuilder.DropTable(
                name: "Xaropes");

            migrationBuilder.DropColumn(
                name: "descricaoComprimido",
                table: "comprimido");
        }
    }
}
