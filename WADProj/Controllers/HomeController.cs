using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WADProj.Models;

namespace WADProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _db;

        public HomeController(ILogger<HomeController> logger, MovieContext db )
        {
            _logger = logger;

            /*
            StreamReader r = new StreamReader("moviesDbJson.txt");
            var json = r.ReadToEnd();
            
            List<MovieJson> allMoviesJson = JsonConvert.DeserializeObject<List<MovieJson>>(json);

           
            foreach (var movieJson in allMoviesJson)
            {
                if (movieJson.PosterPath != null)
                {
                    ICollection<MovieGenre> genresFromAMovie = new List<MovieGenre>();

                    movieJson.Genres.Distinct();
                    foreach (var genreName in movieJson.Genres)
                    {
                        MovieGenre movieGenre = new MovieGenre();

                        Genre newGenre;
                        IList<Genre> GenreList = (from genre in db.Genre
                                                  where genre.GenreName == genreName
                                                  select genre).ToList();

                        if (GenreList.Count == 0)
                        {
                            newGenre = new Genre { GenreName = genreName };


                            newGenre.Movies = new List<MovieGenre>();
                        }
                        else
                        {
                            newGenre = GenreList[0];
                        }
                        movieGenre.Genre = newGenre;

                        newGenre.Movies.Add(movieGenre);
                        genresFromAMovie.Add(movieGenre);
                    }


                    Movie newMovie = new Movie()
                    {
                        Title = movieJson.Title,
                        Overview = movieJson.Overview,
                        ReleaseDate = movieJson.ReleaseDate,
                        PosterPath = movieJson.PosterPath,
                        Popularity = movieJson.Popularity
                    };

                   

                    foreach (var movieGenre in genresFromAMovie)
                    {
                        movieGenre.Movie = newMovie;
                        
                    }

                    
                    newMovie.Genres = genresFromAMovie;

                    try
                    {
                        db.Add<Movie>(newMovie);
                        db.SaveChanges();
                    }
                    catch { }
                }

            }
            */
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
