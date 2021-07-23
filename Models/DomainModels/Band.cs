using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BandDB.Models
{
    public class Band
    {
        public int BandId { get; set; }

        [Required(ErrorMessage = "Please enter a band name.")]
        [StringLength(50, ErrorMessage ="Name must be 50 charaters or less.")]
        public string Name { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Artist> Artists { get; set; } // Navigation property
    }
}
