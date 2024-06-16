using examen.Entidades;
using examen.Persisitencia;
using Microsoft.EntityFrameworkCore;

namespace examen.Servicios
{
    public class SvEstudiante : ISvEstudiante
    {
        private readonly MyDbContext _context;

        public SvEstudiante(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> GetAll()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task<Estudiante> GetById(int id)
        {
            return await _context.Estudiantes.FindAsync(id);
        }

        public async Task<Estudiante> Create(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }
    }
}
