using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeWeb.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Categorias",
                schema: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                schema: "Fornecedor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cnpj = table.Column<string>(maxLength: 15, nullable: true),
                    cpf = table.Column<string>(maxLength: 21, nullable: true),
                    nome = table.Column<string>(maxLength: 80, nullable: false),
                    telefone = table.Column<string>(maxLength: 20, nullable: false),
                    email = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 80, nullable: false),
                    cpf = table.Column<string>(maxLength: 15, nullable: false),
                    data_nascimento = table.Column<DateTime>(nullable: false),
                    pefil = table.Column<string>(maxLength: 20, nullable: false),
                    login = table.Column<string>(maxLength: 20, nullable: false),
                    senha = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Propostas",
                schema: "Proposta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_categoria = table.Column<int>(nullable: false),
                    id_fornecedor = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    data = table.Column<DateTime>(nullable: false),
                    valor = table.Column<decimal>(nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    caminho_arquivo = table.Column<string>(nullable: true),
                    aprovada_analista_compras = table.Column<bool>(nullable: false),
                    aprovada_analista_financeiro = table.Column<bool>(nullable: false),
                    aprovada_diretor_financeiro = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propostas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Propostas_Categorias_id_categoria",
                        column: x => x.id_categoria,
                        principalSchema: "Categoria",
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Propostas_Fornecedores_id_fornecedor",
                        column: x => x.id_fornecedor,
                        principalSchema: "Fornecedor",
                        principalTable: "Fornecedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoPropostas",
                schema: "HistoricoProposta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(maxLength: 255, nullable: false),
                    data = table.Column<DateTime>(nullable: false),
                    id_proposta = table.Column<int>(nullable: false),
                    IdProposta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPropostas", x => x.id);
                    table.ForeignKey(
                        name: "FK_HistoricoPropostas_Propostas_IdProposta",
                        column: x => x.IdProposta,
                        principalSchema: "Proposta",
                        principalTable: "Propostas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoPropostas_Usuarios_id_proposta",
                        column: x => x.id_proposta,
                        principalSchema: "Usuario",
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPropostas_IdProposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                column: "IdProposta");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPropostas_id_proposta",
                schema: "HistoricoProposta",
                table: "HistoricoPropostas",
                column: "id_proposta");

            migrationBuilder.CreateIndex(
                name: "IX_Propostas_id_categoria",
                schema: "Proposta",
                table: "Propostas",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Propostas_id_fornecedor",
                schema: "Proposta",
                table: "Propostas",
                column: "id_fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_login",
                schema: "Usuario",
                table: "Usuarios",
                column: "login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoPropostas",
                schema: "HistoricoProposta");

            migrationBuilder.DropTable(
                name: "Propostas",
                schema: "Proposta");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "Usuario");

            migrationBuilder.DropTable(
                name: "Categorias",
                schema: "Categoria");

            migrationBuilder.DropTable(
                name: "Fornecedores",
                schema: "Fornecedor");
        }
    }
}
