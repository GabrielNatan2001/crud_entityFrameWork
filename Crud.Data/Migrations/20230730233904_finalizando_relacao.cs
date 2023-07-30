using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Data.Migrations
{
    /// <inheritdoc />
    public partial class finalizandorelacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Contato_EntidadePessoaId",
                table: "Contato",
                column: "EntidadePessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Pessoa_EntidadePessoaId",
                table: "Contato",
                column: "EntidadePessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Pessoa_EntidadePessoaId",
                table: "Contato");

            migrationBuilder.DropIndex(
                name: "IX_Contato_EntidadePessoaId",
                table: "Contato");
        }
    }
}
