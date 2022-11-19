using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiPro.API.Models;

namespace WebApiPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new Event[]{
                new Event(){
                    EventId = 1,
                    Theme = "Angular 11 e .NET 5",
                    Local = "Bahia",
                    Batch = "1. Lote",
                    AmountOfPeople = 300,
                    EventData = DateTime.Now.AddDays(5).ToString(),
                    ImageURL = "foto.png"
            },
            new Event(){
                    EventId = 2,
                    Theme = "Angular 11 e Suas Novidades",
                    Local = "Rio de Janeiro",
                    Batch = "2. Lote",
                    AmountOfPeople = 300,
                    EventData = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    ImageURL = "foto2.png"
            }
            };
        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;

        }
        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(Event => Event.EventId == id);

        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
