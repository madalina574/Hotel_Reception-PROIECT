using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Reception_PROIECT.Migrations
{
    public partial class Cazari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CazareID",
                table: "Oaspete",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cazare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumarCamera = table.Column<int>(type: "int", nullable: false),
                    Etaj = table.Column<int>(type: "int", nullable: false),
                    TipCamera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponibilitate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cazare", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oaspete_CazareID",
                table: "Oaspete",
                column: "CazareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Oaspete_Cazare_CazareID",
                table: "Oaspete",
                column: "CazareID",
                principalTable: "Cazare",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oaspete_Cazare_CazareID",
                table: "Oaspete");

            migrationBuilder.DropTable(
                name: "Cazare");

            migrationBuilder.DropIndex(
                name: "IX_Oaspete_CazareID",
                table: "Oaspete");

            migrationBuilder.DropColumn(
                name: "CazareID",
                table: "Oaspete");
        }
    }
}
