using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeWeb_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeWeb.Data.EntityTypeConfigurations
{
    public sealed class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("id");

            builder.Property(x => x.Nome).IsRequired().HasColumnName("nome").HasMaxLength(80);

            builder.Property(x => x.Cpf).IsRequired().HasColumnName("cpf").HasMaxLength(15);

            builder.Property(x => x.DataNascimento).IsRequired().HasColumnName("data_nascimento");

            builder.Property(x => x.Perfil).IsRequired().HasColumnName("perfil").HasMaxLength(20);

            builder.Property(x => x.Login).IsRequired().HasColumnName("login").HasMaxLength(20);

            builder.Property(x => x.Senha).IsRequired().HasColumnName("senha").HasMaxLength(128);

            builder.HasIndex(x => x.Login).IsUnique();

        }
    }
}
