using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Data;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : ControllerBase
    {
        public readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return _context.Eventos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return _context.Eventos.FirstOrDefault(resultado => resultado.EventoId == id);
        }
    }
}