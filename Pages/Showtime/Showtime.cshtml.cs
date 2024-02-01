using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class ShowtimeModel : PageModel
{
    private readonly ILogger<ShowtimeModel> _logger;
    private readonly ApplicationDbContext _context;

    public ShowtimeModel(ILogger<ShowtimeModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public List<ShowEntity> Showtimes { get; set; }
    public int MovieId { get; set; }

    public async Task OnGetAsync(int movieId)
    {
        try
        {
            MovieId = movieId;
            Showtimes = await _context.Showtimes
                .Where(s => s.MovieId == movieId)
                .OrderBy(s => s.ShowDate)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Wystąpił błąd podczas wczytywania seansów.");
            Showtimes = new List<ShowEntity>();
        }
    }
}
