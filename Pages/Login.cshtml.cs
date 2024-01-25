using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class LoginModel : PageModel
{
    private readonly ApplicationDbContext _context;

    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }
//
    private readonly IConfiguration _configuration;

    public LoginModel(ApplicationDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
        _configuration = configuration;
    }
//
    // public LoginModel(ApplicationDbContext context)
    // {
    //     _context = context;
    // }

    public IActionResult OnGet()
    {
        // Do nothing on GET request
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Check username and password, perform authentication logic
        if (await IsValidUserAsync(Username, Password))
        {
            // Przekierowanie po pomyślnej autentykacji
            return RedirectToPage("/Index");
        }
        else
        {
            // Przekierowanie lub obsługa błędu autentykacji
            return Page();
        }
    }

    private async Task<bool> IsValidUserAsync(string username, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == username);
        return user != null && user.Password == password;
 		//return username == "admin" && password == "admin123";
    }
}