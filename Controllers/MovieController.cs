namespace Bajeczkav2.Controllers;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class MovieController : Controller
{
    
    private readonly MovieRepository movieRepository = new MovieRepository();

    private static List<MovieEntity> movies = new List<MovieEntity>
    {
        new MovieEntity("null", "Film 1", new DateTime(2023, 1, 1)),
        new MovieEntity("null", "Film 2", new DateTime(2023, 2, 15)),
        new MovieEntity("null", "Film 3", new DateTime(2023, 3, 30))
    };
    
    public ActionResult Index()
    {	
        Models.MovieViewModel model = new Models.MovieViewModel
        {
            Movies = movies
        };
        Console.WriteLine($"Model is null: {model == null}, Movies count: {model?.Movies?.Count}");
        return View(model);
    }

    public ActionResult Details(int id)
    {
        MovieEntity movie = movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }
}
