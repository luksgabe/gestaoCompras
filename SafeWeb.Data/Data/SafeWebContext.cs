using Microsoft.EntityFrameworkCore;
using SafeWeb.Data.EntityTypeConfigurations;
using SafeWeb_Domain.Entities;

namespace SafeWeb.Data.Data
{
    public class SafeWebContext : DbContext
    {
        public SafeWebContext(DbContextOptions<SafeWebContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<HistoricoProposta> HistoricoPropostas { get; set; }
        public DbSet<Proposta> Propostas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder);
        }

        private static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new HistoricoPropostaConfiguration());
            modelBuilder.ApplyConfiguration(new PropostaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

    }
}
