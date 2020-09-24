using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.Domain;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get ()
        {
            return new Evento[] {
                new Evento() {
                    Id = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Fortaleza",
                    // Lote = "1o lote",
                    QtdPessoas = 250,
                    //DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    Id = 2,
                    Tema = "Angular 10",
                    Local = "Caucaia",
                    // Lote = "2o lote",
                    QtdPessoas = 350,
                    // DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }

            };

        }
        /* public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] 
            {
                new Evento() {
                    Id = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Fortaleza",
                    // Lote = "1o lote",
                    QtdPessoas = 250,
                    // DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    Id = 2,
                    Tema = "Angular 10",
                    Local = "Caucaia",
                    // Lote = "2o lote",
                    QtdPessoas = 350,
                    // DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }

            }.FirstOrDefault(x => x.Id == id);

        }
    }
}
