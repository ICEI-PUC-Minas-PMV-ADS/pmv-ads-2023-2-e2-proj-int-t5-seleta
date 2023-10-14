using Microsoft.EntityFrameworkCore;
using Seleta.Models;

namespace Seleta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(usuario => usuario.Estabelecimentos)
                .WithOne(estabelecimento => estabelecimento.Usuario)
                .HasForeignKey(estabelecimento => estabelecimento.UsuarioCPF)
                .IsRequired();
        }
    }
}
 