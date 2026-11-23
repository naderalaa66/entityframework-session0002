using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class Event
    {
        [Key]
        public int id { get; set; }
        public string Address { get; set; }
        public string  describtion { get; set; }

        public DateTime FristDate { get; set; }
        public DateTime? EndtDate { get; set; }
        public int maxmumattend { get; set; }

        public organizer myorganizer { get; set; }

        [ForeignKey(nameof(myorganizer))]

        public int organizerid { get; set; }




    }
}
