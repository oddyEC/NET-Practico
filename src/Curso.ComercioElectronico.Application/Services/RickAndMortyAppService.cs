using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Curso.ComercioElectronico.Application.Dtos;
using Curso.ComercioElectronico.Application.Interfaces;
using Curso.ComercioElectronico.Domain.Repository;

namespace Curso.ComercioElectronico.Application.Services
{
    public class RickAndMortyAppService : IRickAndMortyService
    {
        private readonly IMapper mapper;
        private readonly IResultRepository repository;

        public ListaPaginada<ResultDto> GetAll(int limit = 10, int offset = 0)
        {
            var consulta = repository.GetAll();

            //Lista 
            // 1. Ejecvutar linq Total registros
            var total = consulta.Count();
            var listaProductosDto = consulta.Skip(offset)
                                            .Take(limit)

                                            .Select(
                                             x => new ResultDto()
                                             {
                                                 id = x.id,
                                                 name = x.name,


                                             }
                                            );
            var resultado = new ListaPaginada<ResultDto>();
            resultado.Total = total;
            resultado.Lista = listaProductosDto.ToList();

            return resultado;
        }
    }
}