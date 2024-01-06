using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bajeczkav2.Pages;

public class TicketModel : PageModel
{
    private readonly ILogger<TicketModel> _logger;

    public TicketModel(ILogger<TicketModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}