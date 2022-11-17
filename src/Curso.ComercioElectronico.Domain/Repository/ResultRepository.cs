using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace Curso.ComercioElectronico.Domain.Repository
{
    public class ResultRepository
    {
        var client = new RestClient("https://rickandmortyapi.com/api/character");
        client.Timeout = -1;
var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
    }
}