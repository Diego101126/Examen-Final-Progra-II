using examen.Entidades;

namespace examen.Servicios
{
    public interface ISvMatricula
    {
        Task<Matricula> Create(Matricula matricula);
        Task<List<Matricula>> GetAll();
        Task<List<Estudiante>> GetEstudiantesByCurso(int cursoId);
        Task<List<Estudiante>> GetEstudiantesByCarrera(int carreraId);
        Task<List<Estudiante>> GetEstudiantesByCarreraAndNivel(int carreraId, int nivel);
        Task<object?> GetById(int id);
    }
}
