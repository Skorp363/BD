using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BD.Pages
{
    [AllowAnonymous]
    public class RegistrationModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToPage("Index"); // Перенаправляем на главную, если пользователь уже авторизован
            }
            return Page();
        }
    }
}
