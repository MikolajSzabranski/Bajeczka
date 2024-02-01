using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bajeczkav2.Controllers;
using Bajeczkav2.Models;

public class RegisterModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<RegisterModel> _logger;
 
    [BindProperty]
    public string NewFirstName { get; set; }
    
    [BindProperty]
    public string NewLastName { get; set; }
    [BindProperty]
    public string NewLogin { get; set; }

    [BindProperty]
    public string NewPassword { get; set; }
    
    
    public RegisterModel(ApplicationDbContext context, ILogger<RegisterModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            if (await IsLoginTakenAsync(NewLogin))
            {
                ModelState.AddModelError("NewLogin", "Login is already taken.");
                return Page();
            }
            await AddNewUserAsync();
            return RedirectToPage("/Login");
        }
        return Page();
    }

    private async Task<bool> IsLoginTakenAsync(string login)
    {
        return await _context.Users.AnyAsync(u => u.Login == login);
    }

    private async Task AddNewUserAsync()
    {
        var newUser = new UserEntity
        {
            FirstName = NewLogin,
            LastName = NewLogin,
            Login = NewLogin,
            AccountType = AccountType.NORMAL.ToString(),
            Password = NewPassword,
        };
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
    }
}
