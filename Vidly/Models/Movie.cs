using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre{ get; set; }

        [Required]
        [Column(TypeName = "date")]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        public byte Stock { get; set; }

    }
}