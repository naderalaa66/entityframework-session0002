using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class organizerprofile
    {
        [Key]
        public int id { get; set; }
        public string Bio { get; set; }
        public string website { get; set; }

        public string logo { get; set; }

        public organizer myorganizer { get; set; }

        [ForeignKey(nameof(myorganizer))]
        public  int organizerId { get; set; }
    }
}
