using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

public class LoginModel : PageModel
{
    private readonly ApplicationDbContext _context;

    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public LoginModel(ApplicationDbContext context)
    {
        _context = context;
    }

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
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == username && u.Password == password);

        if (user != null)
        {
            // Utwórz identyfikator uwierzytelniania z wykorzystaniem Claim
            var claims = new[] { new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            // Utwórz principal
            var principal = new ClaimsPrincipal(identity);

            // Zaloguj użytkownika
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return true;
        }

        return false;
    }
}