using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Bajeczkav2.Pages;

using Bajeczkav2.Controllers;

public class MovieModel : PageModel
{
    private readonly ILogger<MovieModel> _logger;
    private readonly ApplicationDbContext _context;
    private readonly MovieRepository movieRepository = new MovieRepository();

    public MovieModel(ILogger<MovieModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public List<MovieEntity> Movies { get; set; }

    public async Task OnGetAsync()
    {
        try
        {
            Movies = await _context.Movies.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Wystąpił błąd podczas wczytywania filmów.");
            Movies = new List<MovieEntity>();
        }
    }
}

