namespace Bajeczkav2.Pages;

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Bajeczkav2.Controllers;
using Bajeczkav2.Models;

public class BuyTicketModel : PageModel
{
	private readonly ILogger<BuyTicketModel> _logger;
    private readonly ApplicationDbContext _context;
   
    public BuyTicketModel(ILogger<BuyTicketModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
   
    [BindProperty]
    public int ShowtimeId { get; set; }
    
    [BindProperty]
    public string UserId { get; set; }

    [BindProperty]
    public TicketType TicketType { get; set; }

    public async Task<IActionResult> OnPostPurchaseTicket()
    {
        try
        {
            Console.WriteLine(ShowtimeId);
            Console.WriteLine(UserId);
            var newTicket = new TicketEntity
            {
                ShowtimeId = ShowtimeId,
                UserId = 1,//Int32.Parse(UserId),
                PurchaseDate = DateTime.UtcNow,
                TicketType = TicketType.ToString()
            };
            _context.Tickets.Add(newTicket);
            await _context.SaveChangesAsync();
    
            return RedirectToPage("/Movies");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Wystąpił błąd podczas dodawania biletu.");
            return RedirectToPage("/Showtimes/Index?movieId=" + ShowtimeId);
        }
    }
}