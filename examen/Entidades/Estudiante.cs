namespace examen.Entidades
{
    public class Estudiante
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante estudiante { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
