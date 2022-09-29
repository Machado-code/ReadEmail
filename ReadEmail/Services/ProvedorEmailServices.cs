using ELEmail.Data;
using ELEmail.Models;
using Microsoft.EntityFrameworkCore;

namespace ELEmail.Services
{
    public class ProvedorEmailServices
    {
        private readonly AppDbContext _context;

        public ProvedorEmailServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProvedorEmail>> FindAll()
        {
            if (_context.ProvedorEmail == null)
            {
                return new List<ProvedorEmail>();
            }

            return await _context.ProvedorEmail.ToListAsync();
        }

        public async Task<ProvedorEmail> FindById(int id, string cliente)
        {
            if (_context.ProvedorEmail == null)
            {
                return new ProvedorEmail();
            }

            return await _context.ProvedorEmail.FirstOrDefaultAsync(p => p.IdProvedor == id && p.Cliente == cliente);
        }

        public async Task Insert(ProvedorEmail provedorEmail)
        {
            _context.ProvedorEmail?.Add(provedorEmail);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ProvedorEmail provedorEmail)
        {
            _context.Update(provedorEmail);
            await _context.SaveChangesAsync();
        }
    }
}
