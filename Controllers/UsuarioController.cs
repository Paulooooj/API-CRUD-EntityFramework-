using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()
            };

            return Ok(obj);

        }

        [HttpGet("Apresentar /{nome}/{idade}")]
        public IActionResult Apresentar(string nome, int idade)
        {
            var mensagem = $"Olá {nome}, que tem {idade} anos, seja bem vindo!";
            return Ok(new {mensagem});

        }
        
    }
}