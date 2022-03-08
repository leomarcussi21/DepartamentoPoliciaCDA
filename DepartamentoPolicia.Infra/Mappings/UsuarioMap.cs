using DepartamentoPolicia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartamentoPolicia.Infra.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .Property(u => u.Id)
                .IsRequired();

            builder
                .Property(u => u.Nome)
                .HasMaxLength(250)
                .IsRequired();

            builder
                .Property(u => u.Senha)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
