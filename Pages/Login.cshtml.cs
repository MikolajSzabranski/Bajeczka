using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public IActionResult OnGet()
    {
        // Do nothing on GET request
        return Page();
    }

    public IActionResult OnPost()
    {
        // Check username and password, perform authentication logic
        if (IsValidUser(Username, Password))
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

    private bool IsValidUser(string username, string password)
    {
        // Tutaj możesz implementować bardziej skomplikowaną logikę autentykacji
        // W tym przypadku załóżmy, że poprawne dane to "admin" jako nazwa użytkownika i "admin123" jako hasło
        return username == "admin" && password == "admin123";
    }
}