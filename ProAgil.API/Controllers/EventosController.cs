using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Get()
        {
            try
            {
                var resultado = await _context.Eventos.ToListAsync();

                return Ok(resultado);
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sem resposta do Banco de Dados.");
            }            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
               try
            {
                var resultado = await _context.Eventos.FirstOrDefaultAsync(resultado => resultado.EventoId == id);

                return Ok(resultado);
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sem resposta do Banco de Dados.");
            }            
        }
    }
}