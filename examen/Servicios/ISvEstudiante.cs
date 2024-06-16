using examen.Entidades;

namespace examen.Servicios
{
    // Services/ISvEstudiante.cs
    public interface ISvEstudiante
    {
        Task<List<Estudiante>> GetAll();
        Task<Estudiante> GetById(int id);
        Task<Estudiante> Create(Estudiante estudiante);
    }

}
