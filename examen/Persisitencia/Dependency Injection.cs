using examen.Servicios;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace examen.Persisitencia
{
    public class Dependency_Injection
    {
        public void ConfigureServices(IServiceCollection servicios)
        {
            servicios.AddDbContext<MyDbContext>(options =>options.UseSqlServer(this Servicios servicios));

            servicios.AddScoped<ISvCarrera, SvCarrera>();
            servicios.AddScoped<ISvCurso, SvCurso>();
            servicios.AddScoped<ISvEstudiante, SvEstudiante>();
            servicios.AddScoped<ISvMatricula, SvMatricula>();
            

            servicios.AddControllers();
            servicios.AddSwaggerGen();
        }
    }
}
