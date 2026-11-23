using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class organizer
    {
        public int id  { get; set; } 
        public string organizerName { get; set; }
        public string ? CompanyName { get; set; }
        public bool Isverification { get; set; }
        public organizerprofile myorganizerprofile { get; set; }

        public ICollection<Event> myEvent { get; set; } = new HashSet<Event>();

    }
}
