namespace examen.Entidades
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }

}
 