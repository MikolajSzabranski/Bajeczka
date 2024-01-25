namespace Bajeczkav2.Controllers;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class MovieController : Controller
{
    private readonly MovieRepository movieRepository = new MovieRepository();

    public IActionResult Index()
    {
        var movies = movieRepository.GetAllMovies();
        return View(movies);
    }

    public IActionResult Details(int id)
    {
        var movie = movieRepository.GetMovieById(id);
        return View(movie);
    }
}
