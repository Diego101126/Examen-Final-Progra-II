using examen.Entidades;

namespace examen.Servicios
{
    public interface ISvCarrera 
    {
        Task<List<Carrera>> GetAll();
        Task<Carrera> GetById(int id);
        Task<Carrera> Create(Carrera carrera);
    }
}


  


