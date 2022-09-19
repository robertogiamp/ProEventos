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
        public IEnumerable<Evento> _evento =new Evento[]{
        new Evento(){
        EventoId = 1,
        Tema = "Angula 11 e Dot net 5",
        Local = "Belo Horizonte",
        Lote = "1º Lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
        ImagemUrl = "Foto.png",
        },

        new Evento(){
        EventoId = 2,
        Tema = "Angula 11 e Suas novidades",
        Local = "São Paulo",
        Lote = "2º Lote",
        QtdPessoas = 350,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
        ImagemUrl = "Foto1.png",
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

        [HttpGet("{Id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento =>evento.EventoId == id);
        }
    }
}
