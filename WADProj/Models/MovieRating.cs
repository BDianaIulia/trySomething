using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WADProj.Models
{
    public class MovieRating
    {
        [Key]
        public int IdMovieRating { get; set; }
        public int NumberOf5ReviewStars { get; set; }
        public int NumberOf4ReviewStars { get; set; }
        public int NumberOf3ReviewStars { get; set; }
        public int NumberOf2ReviewStars { get; set; }
        public int NumberOf1ReviewStars { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
