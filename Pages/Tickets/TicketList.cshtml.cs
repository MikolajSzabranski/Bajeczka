using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Bajeczkav2.Models;
using Bajeczkav2.Controllers;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

public class TicketListModel : PageModel
{
    private readonly ILogger<TicketListModel> _logger;
    private readonly ApplicationDbContext _context;

    public TicketListModel(ILogger<TicketListModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [BindProperty]
    public string UserId { get; set; }
    
    public List<TicketEntity> Tickets { get; set; }

    public void OnGet()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        Console.WriteLine(userId);
        Tickets = _context.Tickets
            .Where(t => t.UserId == Int32.Parse(userId))
            .ToList();
    }
}