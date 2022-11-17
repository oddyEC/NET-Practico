using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.ComercioElectronico.Application;
using Curso.ComercioElectronico.Application.Dtos;
using Curso.ComercioElectronico.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Curso.ComercioElectronico.HttpApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RickAndMorty : ControllerBase
    {
        private readonly IRickAndMortyService rickService;
        [HttpGet]
        public ListaPaginada<ResultDto> GetAll(int limit = 10, int offset = 0)
        {

            return rickService.GetAll(limit, offset);

        }
    }
}