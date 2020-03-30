using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WADProj.Models
{
    public class Movie
    {
        [Key]
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public double Popularity { get; set; }

        public string ReviewScore { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<MovieGenre> Genres { get; set; }
        public MovieRating MovieRating { get; set; }
        public ICollection<UserMovieActivity> RelatedListUsersActivity { get; set; }

    }
}
