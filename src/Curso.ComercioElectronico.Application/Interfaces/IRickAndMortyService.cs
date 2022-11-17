using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Application.Dtos;

namespace Curso.ComercioElectronico.Application.Interfaces
{
    public interface IRickAndMortyService
    {
        ListaPaginada<ResultDto> GetAll(int limit = 10, int offset = 0);
    }
}