using Microsoft.EntityFrameworkCore;
using Seleta.Models;
using System.Security.Policy;

namespace Seleta.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ListaDeCompras> ListasDeCompras { get; set; }

        public DbSet<ProdutosListaDeCompras> ProdutosListaDeCompras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(usuario => usuario.Estabelecimentos)
                .WithOne(estabelecimento => estabelecimento.Usuario)
                .HasForeignKey(estabelecimento => estabelecimento.UsuarioCPF)
                .IsRequired();

            modelBuilder.Entity<ProdutosListaDeCompras>(pl =>
            {
                pl.HasKey(p => new { p.ProdutoId, p.ListaDeComprasEmail });

                pl.HasOne(pl => pl.ListaDeCompras).
                WithMany(pl => pl.Produtos).HasForeignKey(p => p.ListaDeComprasEmail);

                pl.HasOne(pl => pl.Produto)
                .WithMany(pl => pl.ListasDeCompras).HasForeignKey(p => p.ProdutoId);
            });               
        }
    }
}