using Microsoft.AspNetCore.Mvc;
using WebGeradorMassaDados.Regras;

namespace WebGeradorMassaDados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerarNomes : Controller
    {
        [HttpGet(Name = "Gerador Nome")]
        public string Nome(string sexo)
        { 
            Nomes nomes = new Nomes();
            return nomes.nome(sexo);
        }
    }
}
