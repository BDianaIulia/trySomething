using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WADProj.Models
{
    public class Genre
    {
        [Key]
        public int IdGenre { get; set; }
        public string GenreName { get; set; }
        public ICollection<MovieGenre> Movies { get; set; }
    }
}
