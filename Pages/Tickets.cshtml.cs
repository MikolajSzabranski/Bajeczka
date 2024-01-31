namespace Bajeczkav2.Pages;

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class TicketModel : PageModel
{
    private readonly ILogger<TicketModel> _logger;
    private readonly ApplicationDbContext _context;

    public TicketModel(ILogger<TicketModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public List<ShowEntity> Tickets { get; set; }

    public async Task OnGetAsync(int movieId)
    {
        try
        {
          //Tickets = await _context.Tickets
             //   .Where(s => s.UserId == 1)
                //.OrderBy(s => s.PurchaseDate)
            //    .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Wystąpił błąd podczas wczytywania biletów.");
            Tickets = new List<ShowEntity>();
        }
    }
}
