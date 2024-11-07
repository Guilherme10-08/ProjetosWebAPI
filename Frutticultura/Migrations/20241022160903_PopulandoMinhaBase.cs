using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frutticultura.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoMinhaBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO fruta VALUES(01,'Manga','Fruta Manga')");
			mb.Sql("INSERT INTO fruta VALUES(02,'Banana','Fruta Banana')");
            mb.Sql("INSERT INTO fruta VALUES(03,'Morango','Fruta Morango')");

		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM fruta WHERE idFrutta >= 0");
        }
    }
}
