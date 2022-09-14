using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadEmail.Models;
using ReadEmail.Services;

namespace ReadEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadEmailController : ControllerBase
    {
        [HttpPost("buscaremails")]
        public async Task<ActionResult<IEnumerable<CorpoEmail>>> BuscarEmail()
        {
            try
            {
                BuscaEmail buscar_email = new BuscaEmail();
                List<CorpoEmail> listaCorpo = new List<CorpoEmail>();
                listaCorpo = await buscar_email.Buscar("email-ssl.com.br", 995, "contato@cmdsistemas.dev.br", "CmdSistemas@2022");

                return listaCorpo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
