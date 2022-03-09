using DepartamentoPolicia.Domain.Entities;
using DepartamentoPolicia.Infra.Extensions;
using DepartamentoPolicia.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace DepartamentoPolicia.Infra.Context
{
    public class DepartamentoPoliciaContext : DbContext
    {
        public DepartamentoPoliciaContext(DbContextOptions<DepartamentoPoliciaContext> option)
            : base(option) { }

        #region DbSet
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CodigoCriminal> CodigosCriminais { get; set; }
        public DbSet<Status> Status { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
