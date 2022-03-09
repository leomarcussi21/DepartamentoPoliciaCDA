using DepartamentoPolicia.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartamentoPolicia.Infra.Mappings
{
    public class CodigoCriminalMap
    {
        public void Configure(EntityTypeBuilder<CodigoCriminal> builder)
        {
            builder.HasKey(c=> c.Id);

            builder
                .Property(c=> c.Nome)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .Property(c=> c.Descricao)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .Property(c=> c.Penalidade)
                .IsRequired();

            builder
                .Property(c => c.TempoPrisao)
                .IsRequired();

            builder
                .Property(c => c.StatusId)
                .IsRequired();

            builder
                .Property(c => c.DataCriacao)
                .IsRequired();

            builder
                .Property(c => c.DataAlteracao)
                .IsRequired();

            builder
                .Property(c => c.IdUsuarioCriacao)
                .IsRequired();

            builder
                .Property(c => c.IdUsuarioAlteracao)
                .IsRequired();
        }
    }
}
