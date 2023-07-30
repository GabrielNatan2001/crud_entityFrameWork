using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Data.Migrations
{
    /// <inheritdoc />
    public partial class adicionandorelacao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDI = table.Column<int>(type: "int", nullable: false),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(10)", nullable: false),
                    EntidadePessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");
        }
    }
}
