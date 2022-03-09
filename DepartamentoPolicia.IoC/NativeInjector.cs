using DepartamentoPolicia.Application.Services;
using DepartamentoPolicia.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DepartamentoPolicia.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
