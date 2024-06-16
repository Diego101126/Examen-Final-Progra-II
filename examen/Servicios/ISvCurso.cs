using examen.Entidades;

namespace examen.Servicios
{
    public interface ISvCurso
    {
        Task<List<Curso>> GetAll();
        Task<Curso> GetById(int id);
        Task<Curso> Create(Curso curso);
    }
}
