using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeWeb_Domain.Entities;

namespace SafeWeb.Data.EntityTypeConfigurations
{
    public sealed class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("id");

            builder.Property(x => x.Nome).IsRequired().HasColumnName("nome").HasMaxLength(40);
        }

    }
}
