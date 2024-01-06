namespace Bajeczkav2;

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class MovieController : Controller
{
    private static List<MovieEntity> movies = new List<MovieEntity>
    {
        new MovieEntity("null", "Film 1", new DateTime(2023, 1, 1)),
        new MovieEntity("null", "Film 2", new DateTime(2023, 2, 15)),
        new MovieEntity("null", "Film 3", new DateTime(2023, 3, 30))
    };
    
    public ActionResult Index()
    {
        // List<MovieEntity> movies = _context.Filmy.ToList();
        return View(movies);
    }

    public ActionResult Details(int id)
    {
        // MovieEntity movie = movies.FirstOrDefault(m => m.Id == id);
        // if (movie == null)
        // {
        //     return NotFound();
        // }
        //
        // return View(movie);
        return View(movies);
    }
}