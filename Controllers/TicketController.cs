namespace Bajeczkav2.Controllers;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class TicketController : Controller
{
    private readonly ApplicationDbContext _context;
	private readonly ILogger<TicketController> _logger;

	public TicketController(ApplicationDbContext context, ILogger<TicketController> logger)
	{
   		_context = context;
    	_logger = logger;
	}

[HttpPost]
    public async Task<IActionResult> BuyTicket(int showtimeId)
    {
		_logger.LogInformation($"ShowtimeId: {showtimeId}");
        try
        {
            var newTicket = new TicketEntity
            {
                ShowtimeId = showtimeId,
                UserId = 1,
            };

            _context.Tickets.Add(newTicket);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Ticket/Confirmation");

			//var currentUrl = Url.ActionContext.HttpContext.Request.GetDisplayUrl();
        	//return Content($"<script>window.location.href = '{currentUrl}';</script>");
 
        }
        catch (Exception ex)
        {
            return RedirectToPage("/Ticket/Error");
        }
    }

    public IActionResult PurchaseConfirmation()
    {
        return View();
    }
}
