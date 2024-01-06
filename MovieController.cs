namespace Bajeczkav2;

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class MovieController : Controller
{
    // Przykładowa lista filmów
    private static List<Movie> movies = new List<Movie>
    {
        new Movie(1, "Film 1", "Akcja", new DateTime(2023, 1, 1)),
        new Movie(2, "Film 2", "Komedia", new DateTime(2023, 2, 15)),
        new Movie(3, "Film 3", "Dramat", new DateTime(2023, 3, 30))
    };

    // Akcja wyświetlająca listę filmów
    public ActionResult Index()
    {
        return View(movies);
    }

    // Akcja wyświetlająca szczegóły filmu
    public ActionResult Details(int id)
    {
        Movie movie = movies.FirstOrDefault(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }
}