using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeWeb_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeWeb.Data.EntityTypeConfigurations
{
    public sealed class HistoricoPropostaConfiguration : IEntityTypeConfiguration<HistoricoProposta>
    {
        public void Configure(EntityTypeBuilder<HistoricoProposta> builder)
        {
            builder.ToTable("historico_proposta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("id");

            builder.Property(x => x.Descricao).IsRequired().HasColumnName("descricao").HasMaxLength(255);

            builder.Property(x => x.data).IsRequired();

            builder.Property(x => x.IdUsuario).IsRequired().HasColumnName("id_usuario");
            builder.HasOne(x => x.usuario).WithMany().HasForeignKey(x => x.IdUsuario);

            builder.Property(x => x.IdProposta).IsRequired().HasColumnName("id_proposta");
            builder.HasOne(x => x.proposta).WithMany().HasForeignKey(x => x.IdProposta);
        }
    }
}
