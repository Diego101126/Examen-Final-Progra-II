namespace examen.Entidades
{
    public class Curso
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Carrera { get; set; }

        public Carrera carrera { get; set; }
        public int Nivel { get; set; }
        public ICollection<Matricula> Matriculas {get; set;}
        public int IdCarrera { get; internal set; }
        
    }
}


