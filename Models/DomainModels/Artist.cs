using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BandDB.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(30, ErrorMessage = "Name must be 30 characters or less.")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage ="Please enter a last name.")]
        [StringLength(45, ErrorMessage ="Name must be 45 characters or less.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,45}$")]
        public string LastName { get; set; }
        public int BandId { get; set; } // FK
        public Band Band { get; set; } 

        // readonly display property
        public string FullName => $"{FirstName} {LastName}";
    }
}
