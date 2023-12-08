using crud.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud.Service
{
    public class VagasService
    {
        private readonly VagasContext _context;

        public VagasService(VagasContext context)
        {
            _context = context;
        }

        public async Task<List<Vaga>> GetAllVagas()
        {
            // Retorna todas as vagas do banco de dados
            return await _context.Vagas.ToListAsync();
        }

        public async Task AddVaga(Vaga vaga)
        {
            _context.Vagas.Add(vaga);
            await _context.SaveChangesAsync();
        }

        public async Task<Vaga> GetVagaById(int id)
        {
            return await _context.Vagas.FindAsync(id);
        }

        public async Task UpdateVaga(Vaga vaga)
        {
            _context.Entry(vaga).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVaga(int id)
        {
            var vaga = await _context.Vagas.FindAsync(id);
            if (vaga != null)
            {
                _context.Vagas.Remove(vaga);
                await _context.SaveChangesAsync();
            }
        }
    }
}
