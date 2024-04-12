using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
          
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento{
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
                },
                new Evento{
                EventoId = 2,
                Tema = "Angular 11 e .NET 6",
                Local = "Rio Grande Do Sul",
                Lote = "2º Lote",
                QtdPessoas = 50,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemUrl = "foto2.png"
                },
                new Evento{
                EventoId = 3,
                Tema = "Angular 11 e .NET 7",
                Local = "São Luiz",
                Lote = "1º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                ImagemUrl = "foto3.png"
                },
                new Evento{
                EventoId = 4,
                Tema = "Angular 11 e .NET 8",
                Local = "Rio Grande Do Norte",
                Lote = "4º Lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemUrl = "foto5.png"
                }
            };
    
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            
            return _evento.Where(e => e.EventoId == id);
        }

 
        

    }
}
