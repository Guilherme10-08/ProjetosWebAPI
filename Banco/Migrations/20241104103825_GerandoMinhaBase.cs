using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Banco.Migrations
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
                name: "aberturaconta",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nomeCliente = table.Column<string>(type: "longtext", nullable: false),
                    numeroBilheteIdentidadeCliente = table.Column<string>(type: "longtext", nullable: false),
                    tipoMoedaCliente = table.Column<string>(type: "longtext", nullable: false),
                    saldoContaCliente = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    numeroContaCliente = table.Column<string>(type: "longtext", nullable: false),
                    numeroIbanCliente = table.Column<string>(type: "longtext", nullable: false),
                    dataAberturaContaCliente = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aberturaconta", x => x.idCliente);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aberturaconta");
        }
    }
}
