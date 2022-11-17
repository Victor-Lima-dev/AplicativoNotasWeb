using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicativoNotasWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anotacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnotacaoFaculdadeId = table.Column<int>(type: "int", nullable: true),
                    NomedaAula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomedaMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnotacaoProjetoId = table.Column<int>(type: "int", nullable: true),
                    NomeProjeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinguagemProjeto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkProjeto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacoes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anotacoes");
        }
    }
}
