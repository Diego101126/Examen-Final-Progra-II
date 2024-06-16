using examen.Entidades;
using examen.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ISvCurso _Svcurso;

        public CursoController(ISvCurso Svcurso)
        {
            _Svcurso = Svcurso;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<Curso>>> GetAll()
        {
            return Ok(await _Svcurso.GetAll());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetById(int id)
        {
            return Ok(await _Svcurso.GetById(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Curso>> Create(Curso curso)
        {
            return Ok(await _Svcurso.Create(curso));
        }


    }
}
