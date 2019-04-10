using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeWeb_Domain.Entities;

namespace SafeWeb.Data.EntityTypeConfigurations
{
    public sealed class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("id");

            builder.Property(x => x.Cpf).HasColumnName("cpf").HasMaxLength(15);
            builder.Property(x => x.Cnpj).HasColumnName("cnpj").HasMaxLength(21);

            builder.Property(x => x.Nome).IsRequired().HasColumnName("nome").HasMaxLength(80);
            builder.Property(x => x.Telefone).IsRequired().HasColumnName("telefone").HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired().HasColumnName("email").HasMaxLength(80);
        }
    }
}
