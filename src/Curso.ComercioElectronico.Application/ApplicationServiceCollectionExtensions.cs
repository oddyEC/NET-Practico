using System.Reflection;
using Curso.ComercioElectronico.Application.Dtos;
using Curso.ComercioElectronico.Application.Interfaces;
using Curso.ComercioElectronico.Application.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Curso.ComercioElectronico.Application
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration config)
        {


            services.AddTransient<IRickAndMortyService, RickAndMortyAppService>();

            //Configurar la inyección de todos los profile que existen en un Assembly
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //Configurar los validaciones
            // services.AddScoped<IValidator<MarcaCrearActualizarDto>,
            //                 MarcaCrearActualizarDtoValidator>();


            //Configurar todas las validaciones
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;

        }
    }
}