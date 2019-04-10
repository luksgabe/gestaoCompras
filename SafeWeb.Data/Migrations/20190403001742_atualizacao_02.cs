using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeWeb.Data.Migrations
{
    public partial class atualizacao_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Fornecedor",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Fornecedor",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Fornecedor",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Fornecedor",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 21,
                oldNullable: true);
        }
    }
}
