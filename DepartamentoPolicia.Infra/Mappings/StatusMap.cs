using DepartamentoPolicia.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DepartamentoPolicia.Infra.Mappings
{
    public class StatusMap
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .HasMaxLength(400)
                .IsRequired();
        }
    }
}
