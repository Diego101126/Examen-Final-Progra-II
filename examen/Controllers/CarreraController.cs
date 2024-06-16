using examen.Entidades;
using examen.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private readonly ISvCarrera _Svcarrera;

        public CarreraController(ISvCarrera Svcarrera)
        {
            _Svcarrera = Svcarrera;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<Carrera>>> GetAll()
        {
            return Ok(await _SvCarrera.GetAll());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrera>> GetById(int id)
        {
            return Ok(await _Svcarrera.GetById(id));
        }


        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Carrera>> Create(Carrera carrera)
        {
            return Ok(await _Svcarrera.Create(carrera));
        }


    }
}
