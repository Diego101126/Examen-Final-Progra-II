using examen.Entidades;
using examen.Persisitencia;
using Microsoft.EntityFrameworkCore;

namespace examen.Servicios
{
    public class SvNivel : ISvNivel
    {
        private readonly MyDbContext _context;

        public SvNivel(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Nivel> Create(Nivel nivel)
        {
            _context.Nivel.Add(nivel);
            await _context.SaveChangesAsync();
            return Nivel;
        }

        public async Task<List<Nivel>> GetAll()
        {
            return await _context.Nivel
                .Include(m => m.Nivel)
                .Include(m => m.Nivel)
                .ThenInclude(c => c.Nivel)
                .ToListAsync();
        }

        public async Task<List<Estudiante>> GetEstudiantesByCurso(int cursoId)
        {
            return await _context.Matriculas
                .Where(m => m.CursoId == cursoId)
                .Select(m => m.Estudiante)
                .ToListAsync();
        }
    }
}
