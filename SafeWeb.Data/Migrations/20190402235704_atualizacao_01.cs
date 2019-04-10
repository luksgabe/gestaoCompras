using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeWeb.Data.Migrations
{
    public partial class atualizacao_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoPropostas_Propostas_IdProposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoPropostas_Usuarios_id_proposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas");

            migrationBuilder.DropForeignKey(
                name: "FK_Propostas_Categorias_id_categoria",
                schema: "Proposta",
                table: "Propostas");

            migrationBuilder.DropForeignKey(
                name: "FK_Propostas_Fornecedores_id_fornecedor",
                schema: "Proposta",
                table: "Propostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                schema: "Usuario",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propostas",
                schema: "Proposta",
                table: "Propostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoPropostas",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedores",
                schema: "Fornecedor",
                table: "Fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                schema: "Categoria",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                schema: "Usuario",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Propostas",
                schema: "Proposta",
                newName: "Proposta");

            migrationBuilder.RenameTable(
                name: "HistoricoPropostas",
                schema: "HistoricoProposta",
                newName: "HistoricoProposta");

            migrationBuilder.RenameTable(
                name: "Fornecedores",
                schema: "Fornecedor",
                newName: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Categorias",
                schema: "Categoria",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "pefil",
                table: "Usuario",
                newName: "perfil");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_login",
                table: "Usuario",
                newName: "IX_Usuario_login");

            migrationBuilder.RenameIndex(
                name: "IX_Propostas_id_fornecedor",
                table: "Proposta",
                newName: "IX_Proposta_id_fornecedor");

            migrationBuilder.RenameIndex(
                name: "IX_Propostas_id_categoria",
                table: "Proposta",
                newName: "IX_Proposta_id_categoria");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoPropostas_id_proposta",
                table: "HistoricoProposta",
                newName: "IX_HistoricoProposta_id_proposta");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoPropostas_IdProposta",
                table: "HistoricoProposta",
                newName: "IX_HistoricoProposta_IdProposta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proposta",
                table: "Proposta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoProposta",
                table: "HistoricoProposta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Proposta_Categoria_id_categoria",
                table: "Proposta",
                column: "id_categoria",
                principalTable: "Categoria",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposta_Fornecedor_id_fornecedor",
                table: "Proposta",
                column: "id_fornecedor",
                principalTable: "Fornecedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoProposta_Proposta_IdProposta",
                table: "HistoricoProposta");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoProposta_Usuario_id_proposta",
                table: "HistoricoProposta");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposta_Categoria_id_categoria",
                table: "Proposta");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposta_Fornecedor_id_fornecedor",
                table: "Proposta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proposta",
                table: "Proposta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoProposta",
                table: "HistoricoProposta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.EnsureSchema(
                name: "Categoria");

            migrationBuilder.EnsureSchema(
                name: "Fornecedor");

            migrationBuilder.EnsureSchema(
                name: "HistoricoProposta");

            migrationBuilder.EnsureSchema(
                name: "Proposta");

            migrationBuilder.EnsureSchema(
                name: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios",
                newSchema: "Usuario");

            migrationBuilder.RenameTable(
                name: "Proposta",
                newName: "Propostas",
                newSchema: "Proposta");

            migrationBuilder.RenameTable(
                name: "HistoricoProposta",
                newName: "HistoricoPropostas",
                newSchema: "HistoricoProposta");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Fornecedores",
                newSchema: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias",
                newSchema: "Categoria");

            migrationBuilder.RenameColumn(
                name: "perfil",
                schema: "Usuario",
                table: "Usuarios",
                newName: "pefil");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_login",
                schema: "Usuario",
                table: "Usuarios",
                newName: "IX_Usuarios_login");

            migrationBuilder.RenameIndex(
                name: "IX_Proposta_id_fornecedor",
                schema: "Proposta",
                table: "Propostas",
                newName: "IX_Propostas_id_fornecedor");

            migrationBuilder.RenameIndex(
                name: "IX_Proposta_id_categoria",
                schema: "Proposta",
                table: "Propostas",
                newName: "IX_Propostas_id_categoria");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoProposta_id_proposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                newName: "IX_HistoricoPropostas_id_proposta");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoProposta_IdProposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                newName: "IX_HistoricoPropostas_IdProposta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                schema: "Usuario",
                table: "Usuarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propostas",
                schema: "Proposta",
                table: "Propostas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoPropostas",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedores",
                schema: "Fornecedor",
                table: "Fornecedores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                schema: "Categoria",
                table: "Categorias",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoPropostas_Propostas_IdProposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                column: "IdProposta",
                principalSchema: "Proposta",
                principalTable: "Propostas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoPropostas_Usuarios_id_proposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                column: "id_proposta",
                principalSchema: "Usuario",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propostas_Categorias_id_categoria",
                schema: "Proposta",
                table: "Propostas",
                column: "id_categoria",
                principalSchema: "Categoria",
                principalTable: "Categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propostas_Fornecedores_id_fornecedor",
                schema: "Proposta",
                table: "Propostas",
                column: "id_fornecedor",
                principalSchema: "Fornecedor",
                principalTable: "Fornecedores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
