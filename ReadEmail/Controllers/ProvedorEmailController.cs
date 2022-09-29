using ELEmail.Data;
using ELEmail.Models;
using ELEmail.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvedorEmailController : ControllerBase
    {
        private readonly ProvedorEmailServices _provedorServices;
        private readonly AppDbContext _context;

        public ProvedorEmailController(AppDbContext context, ProvedorEmailServices provedorEmailServices)
        {
            _context = context;
            _provedorServices = provedorEmailServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvedorEmail>>> GetProvedor()
        {
            var provedor = await _provedorServices.FindAll();
            if (provedor == null)
            {
                return NotFound();
            }

            return provedor;
        }


        [Route("{idProvedor}/cliente/{cliente}")]
        [HttpGet]
        public async Task<ActionResult<ProvedorEmail>> GetProvedor(int idProvedor, string cliente)
        {
            var provedor = await _provedorServices.FindById(idProvedor, cliente);

            if (provedor == null)
            {
                return NotFound();
            }

            return provedor;
        }

        [HttpPut("{idProvedor}")]
        public async Task<IActionResult> PutAcesso(int idProvedor, ProvedorEmail provedorEmail)
        {
            if (idProvedor != provedorEmail.IdProvedor)
            {
                return BadRequest();
            }

            try
            {
                await _provedorServices.Update(provedorEmail);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvedorEmailExists(idProvedor))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProvedorEmail>> PostAcesso(ProvedorEmail provedorEmail)
        {
            if (_context.ProvedorEmail == null)
            {
                return Problem("Entity set 'AppDbContext.Acesso'  is null.");
            }
            await _provedorServices.Insert(provedorEmail);

            return CreatedAtAction("GetProvedor", new { idProvedor = provedorEmail.IdProvedor, cliente = provedorEmail.Cliente }, provedorEmail);
        }

        private bool ProvedorEmailExists(int id)
        {
            return (_context.ProvedorEmail?.Any(e => e.IdProvedor == id)).GetValueOrDefault();
        }
    }
}
