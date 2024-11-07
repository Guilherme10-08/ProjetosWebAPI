using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Farmacia.Migrations
{
    /// <inheritdoc />
    public partial class GerandoMinhaBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comprimido",
                columns: table => new
                {
                    idComprimido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeComprimido = table.Column<string>(type: "longtext", nullable: false),
                    precoComprimido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stockComprimido = table.Column<int>(type: "int", nullable: false),
                    dataFabricoComprimido = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataExpiracaoComprimido = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprimido", x => x.idComprimido);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comprimido");
        }
    }
}
