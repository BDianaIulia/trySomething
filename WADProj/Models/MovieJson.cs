using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADProj.Models
{
    public class MovieJson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public List<string> Genres { get; set; }
        public string PosterPath { get; set; }
        public double Popularity { get; set; }
    }
}
