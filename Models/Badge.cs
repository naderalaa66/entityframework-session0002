using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class Badge
    {
        [Key]
         public int uniqueAttendeeNumber { get; set; }
         public DateTime modelout { get; set; }
         public string catorage { get; set; }

        public Attendee myAttendee { get; set; }

        [ForeignKey(nameof(myAttendee))]
        public int fkid { get; set; }


    }
}
