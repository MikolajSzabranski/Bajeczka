namespace Bajeczkav2.Controllers;

using System.Collections.Generic;

public class MovieRepository
{
    private static List<MovieEntity> movies = new List<MovieEntity>
    {
        new MovieEntity("null", "Film 1", new DateTime(2023, 1, 1)),
        new MovieEntity("null", "Film 2", new DateTime(2023, 2, 15)),
    };

    public List<MovieEntity> GetAllMovies()
    {
        return movies;
    }

    public MovieEntity GetMovieById(int id)
    {
        return movies.Find(m => m.Id == id);
    }
}
