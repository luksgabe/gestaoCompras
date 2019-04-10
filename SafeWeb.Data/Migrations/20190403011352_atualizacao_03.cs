using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeWeb.Data.Migrations
{
    public partial class atualizacao_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoProposta_Proposta_IdProposta",
                table: "HistoricoProposta");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoProposta_Usuario_id_proposta",
                table: "HistoricoProposta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoProposta",
                table: "HistoricoProposta");

            migrationBuilder.RenameTable(
                name: "HistoricoProposta",
                newName: "historico_proposta");

            migrationBuilder.RenameColumn(
                name: "IdProposta",
                table: "historico_proposta",
                newName: "id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoProposta_id_proposta",
                table: "historico_proposta",
                newName: "IX_historico_proposta_id_proposta");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoProposta_IdProposta",
                table: "historico_proposta",
                newName: "IX_historico_proposta_id_usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_historico_proposta",
                table: "historico_proposta",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_historico_proposta_Proposta_id_proposta",
                table: "historico_proposta",
                column: "id_proposta",
                principalTable: "Proposta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_historico_proposta_Usuario_id_usuario",
                table: "historico_proposta",
                column: "id_usuario",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_historico_proposta_Proposta_id_proposta",
                table: "historico_proposta");

            migrationBuilder.DropForeignKey(
                name: "FK_historico_proposta_Usuario_id_usuario",
                table: "historico_proposta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_historico_proposta",
                table: "historico_proposta");

            migrationBuilder.RenameTable(
                name: "historico_proposta",
                newName: "HistoricoProposta");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "HistoricoProposta",
                newName: "IdProposta");

            migrationBuilder.RenameIndex(
                name: "IX_historico_proposta_id_usuario",
                table: "HistoricoProposta",
                newName: "IX_HistoricoProposta_IdProposta");

            migrationBuilder.RenameIndex(
                name: "IX_historico_proposta_id_proposta",
                table: "HistoricoProposta",
                newName: "IX_HistoricoProposta_id_proposta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoProposta",
                table: "HistoricoProposta",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoProposta_Proposta_IdProposta",
                table: "HistoricoProposta",
                column: "IdProposta",
                principalTable: "Proposta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoProposta_Usuario_id_proposta",
                table: "HistoricoProposta",
                column: "id_proposta",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
