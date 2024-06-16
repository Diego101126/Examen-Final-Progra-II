using examen.Entidades;
using examen.Persisitencia;
using Microsoft.EntityFrameworkCore;

namespace examen.Servicios
{
    public class SvCurso : ISvCurso
    {
        private readonly MyDbContext _context;

        public SvCurso(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Curso>> GetAll()
        {
            return await _context.Cursos.ToListAsync();
        }

        public async Task<Curso> GetById(int id)
        {
            return await _context.Cursos.FindAsync(id);
        }

        public async Task<Curso> Create(Curso curso)
        {
            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();
            return curso;
        }
    }
}
