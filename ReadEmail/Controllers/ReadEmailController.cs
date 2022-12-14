using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ELEmail.Models;
using ELEmail.Services;

namespace ELEmail.Controllers
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
                listaCorpo = await buscar_email.Buscar();

                return listaCorpo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
