using examen.Entidades;
using examen.Persisitencia;
using Microsoft.EntityFrameworkCore;

namespace examen.Servicios
{
    public class SvMatricula : ISvMatricula
    {
        private readonly MyDbContext _context;

        public SvMatricula(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Matricula> Create(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();
            return matricula;
        }

        public async Task<List<Matricula>> GetAll()
        {
            return await _context.Matriculas
                .Include(m => m.Estudiante)
                .Include(m => m.Curso)
                .ThenInclude(c => c.Carrera)
                .ToListAsync();
        }

        public async Task<List<Estudiante>> GetEstudiantesByCurso(int cursoId)
        {
            return await _context.Matriculas
                .Where(m => m.CursoId == cursoId)
                .Select(m => m.Estudiante)
                .ToListAsync();
        }

        public async Task<List<Estudiante>> GetEstudiantesByCarrera(int IdCarrera)
        {
            return await _context.Matriculas
                .Where(m => m.Curso.IdCarrera == IdCarrera)
                .Select(m => m.Estudiante)
                .ToListAsync();
        }

        public async Task<List<Estudiante>> GetEstudiantesByCarreraAndNivel(int carreraId, int nivel)
        {
            return await _context.Matriculas
                .Where(m => m.Curso.IdCarrera == carreraId && m.Curso.Nivel == nivel)
                .Select(m => m.Estudiante)
                .ToListAsync();
        }

        public Task<object?> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
