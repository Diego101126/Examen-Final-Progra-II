using examen.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace examen.Persisitencia
{
    // Data/MyDbContext.cs
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nivel> Niveles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Carrera>()
                .HasMany(c => c.Cursos)
                .WithOne(c => c.Carrera)
                .HasForeignKey(c => c.IdCarrera);

            modelBuilder.Entity<Curso>()
                .HasMany(c => c.Matriculas)
                .WithOne(m => m.Curso)
                .HasForeignKey(m => m.CursoId);

            modelBuilder.Entity<Estudiante>()
                .HasMany(e => e.Matriculas)
                .WithOne(m => m.Estudiante)
                .HasForeignKey(m => m.EstudianteId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
