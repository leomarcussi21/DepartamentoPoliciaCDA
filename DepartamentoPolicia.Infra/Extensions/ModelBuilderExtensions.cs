using DepartamentoPolicia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoPolicia.Infra.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .HasData(
                    new Usuario { Id = Guid.Parse("8a2fee16-6b7c-4743-a3ec-d9b879d3a206"), Nome = "admin", Senha = "@dmin"}
                );

            return builder;
        }
    }
}
