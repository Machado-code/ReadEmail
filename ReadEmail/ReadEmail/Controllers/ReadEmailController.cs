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
        public async Task<ActionResult<IEnumerable<CorpoEmail>>> BuscarEmail([FromForm] ProvedorEmail provedorEmail)
        {
            try
            {
                BuscaEmail buscar_email = new BuscaEmail();
                List<CorpoEmail> listaCorpo = new List<CorpoEmail>();
                listaCorpo = await buscar_email.Buscar(provedorEmail.ServidorEntradaPop, provedorEmail.Porta, provedorEmail.Email, provedorEmail.Senha);

                return listaCorpo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
