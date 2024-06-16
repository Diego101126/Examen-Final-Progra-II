using examen.Entidades;

namespace examen.Servicios
{
    public interface ISvNivel
    {
        Task<List<Nivel>> GetAll();
        Task<Nivel> GetById(int id);
        Task<Nivel> Create(Nivel nivel
            );
    }
}

