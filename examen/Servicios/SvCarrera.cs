using examen.Entidades;
using examen.Persisitencia;
using Microsoft.EntityFrameworkCore;


namespace examen.Servicios
{
    public class SvCarrera : ISvCarrera
    {
            private readonly MyDbContext _context;

            public SvCarrera(MyDbContext context)
            {
                _context = context;
            }

            public async Task<List<Carrera>> GetAll()
            {
                return await _context.Carreras.ToListAsync();
            }

            public async Task<Carrera> GetById(int id)
            {
                return await _context.Carreras.FindAsync(id);
            }

            public async Task<Carrera> Create(Carrera carrera)
            {
                _context.Carreras.Add(carrera);
                await _context.SaveChangesAsync();
                return carrera;
            }
        }
}

