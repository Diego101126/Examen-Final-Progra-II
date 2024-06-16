using examen.Entidades;
using examen.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly ISvMatricula _SvMatricula;

        public MatriculaController(ISvMatricula SvMatricula)
        {
            _SvMatricula = SvMatricula;
        }

        // GET: api/<MatriculaController>
        [HttpGet]
        public async Task<ActionResult<List<Matricula>>> GetAll()
        {
            return Ok(await _SvMatricula.GetAll());
        }

        // GET api/<MatriculaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Matricula>> GetById(int id)
        {
            return Ok(await _SvMatricula.GetById(id));
        }

        // POST api/<MatriculaController>
        [HttpPost]
        public async Task<ActionResult<Matricula>> Create(Matricula Matricula)
        {
            return Ok(await _SvMatricula.Create(Matricula));
        }
    }

}
