using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hkd.ms.gestaoUsuario.Migrations
{
    public partial class UserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Midias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Golpes",
                columns: table => new
                {
                    IdGolpe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    MidiauCurtaId = table.Column<int>(nullable: true),
                    MidiaLongaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golpes", x => x.IdGolpe);
                    table.ForeignKey(
                        name: "FK_Golpes_Midias_MidiaLongaId",
                        column: x => x.MidiaLongaId,
                        principalTable: "Midias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Golpes_Midias_MidiauCurtaId",
                        column: x => x.MidiauCurtaId,
                        principalTable: "Midias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Golpes_MidiaLongaId",
                table: "Golpes",
                column: "MidiaLongaId");

            migrationBuilder.CreateIndex(
                name: "IX_Golpes_MidiauCurtaId",
                table: "Golpes",
                column: "MidiauCurtaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Golpes");

            migrationBuilder.DropTable(
                name: "Midias");
        }
    }
}
