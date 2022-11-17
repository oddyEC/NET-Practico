using AutoMapper;
using Curso.ComercioElectronico.Application.Dtos;
using Curso.ComercioElectronico.Domain;
using Curso.ComercioElectronico.Domain.Entidades;

namespace Curso.ComercioElectronico.Application.Mapeos
{
    public class ConfiguracionesMapeoProfile :  Profile
    {
        //TipoProductoCrearActualizarDto => TipoProducto
        //TipoProducto => TipoProductoDto
        public ConfiguracionesMapeoProfile()
        {

          
            CreateMap<Result, ResultDto>();

            //TODO: Agregar otros mapeos que se requieren...

        }
    }
}