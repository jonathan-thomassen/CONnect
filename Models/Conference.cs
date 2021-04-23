using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONnect.Models
{
    public class Conference
    {
        public int ConferenceId { get; set; }
        public string Name { get; set; }
        public List<string> EventThemes { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<Event> Events { get; set; }
    }
}
