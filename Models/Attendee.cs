using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Models
{
    internal class Attendee
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string streatAdrees { get; set; }
        [Required]
        [MaxLength(100)]
        public string CityAdrees { get; set; }
        [Required]
        [MaxLength(100)]
        public string countryAdrees { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("Zipcode")]
        public string symbolAdrees { get; set; }

        [NotMapped]
        public string FullAddress => $"{streatAdrees} ,{CityAdrees} ,{countryAdrees} ,{symbolAdrees}";

        public Badge? myBadge { get; set; }


    }
}
