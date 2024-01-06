using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bajeczkav2.Pages;

public class MovieModel : PageModel
{
    private readonly ILogger<MovieModel> _logger;

    public MovieModel(ILogger<MovieModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

