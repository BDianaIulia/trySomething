using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WADProj.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserMovieActivity> RelatedListMovies { get; set; }
    }
}
