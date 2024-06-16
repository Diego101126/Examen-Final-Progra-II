using examen.Entidades;
using examen.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace examen.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private readonly ISvEstudiante _SvEstudiante;

        public EstudianteController(ISvEstudiante SvEstudiante)
        {
            _SvEstudiante = SvEstudiante;
        }
        // GET: api/<Estudiante>
        [HttpGet]
        public async Task<ActionResult<List<Estudiante>>> GetAll()
        {
            return Ok(await _SvEstudiante.GetAll());
        }

        // GET api/<Estudiante>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetById(int id)
        {
            return Ok(await _SvEstudiante.GetById(id));
        }

        // POST api/<Estudiante>
        [HttpPost]
        public async Task<ActionResult<Estudiante>> Create(Estudiante Estudiante)
        {
            return Ok(await _SvEstudiante.Create(Estudiante));
        }
        }

        
    
}
