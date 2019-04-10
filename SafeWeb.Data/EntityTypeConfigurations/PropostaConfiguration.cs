using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeWeb_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeWeb.Data.EntityTypeConfigurations
{
    public sealed class PropostaConfiguration : IEntityTypeConfiguration<Proposta>
    {
        public void Configure(EntityTypeBuilder<Proposta> builder)
        {
            builder.ToTable("Proposta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("id");

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100).HasColumnName("nome");

            builder.Property(x => x.Data).IsRequired().HasColumnName("data");

            builder.Property(x => x.Valor).IsRequired().HasColumnName("valor");

            builder.Property(x => x.Descricao).IsRequired().HasColumnName("descricao");

            builder.Property(x => x.CaminhoArquivo).HasColumnName("caminho_arquivo");

            builder.Property(x => x.AprovadaAnalistaCompras).HasColumnName("aprovada_analista_compras");

            builder.Property(x => x.AprovadaAnalistaFinanceiro).HasColumnName("aprovada_analista_financeiro");

            builder.Property(x => x.AprovadaDiretorFinanceiro).HasColumnName("aprovada_diretor_financeiro");

            builder.Property(x => x.IdCategoria).IsRequired().HasColumnName("id_categoria");
            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.IdCategoria);

            builder.Property(x => x.IdFornecedor).IsRequired().HasColumnName("id_fornecedor");
            builder.HasOne(x => x.Fornecedor).WithMany().HasForeignKey(x => x.IdFornecedor);
        }
    }
}
