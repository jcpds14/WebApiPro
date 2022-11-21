using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProEvents.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string EventData { get; set; }
        public string Theme { get; set; }
        public int AmountOfPeople { get; set; }
        public string Batch { get; set; }
        public string ImageURL { get; set; }
    }
}