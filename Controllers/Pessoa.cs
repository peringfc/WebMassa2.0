using Microsoft.AspNetCore.Mvc;
using WebGeradorMassaDados.Regras;

namespace WebGeradorMassaDados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pessoa : Controller
    {
        [HttpGet(Name = "Gerador Pessoa")]
        public WebGeradorMassaDados.Objetos.Pessoa Pessoal(int IdadeInicial, int IdadeFinal)
        {
            Fabricar fabricar = new Fabricar();
            return fabricar.Criar(IdadeInicial, IdadeFinal);
        }
    }

}
