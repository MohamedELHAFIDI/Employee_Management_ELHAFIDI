using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;

namespace Employee_Management_ELHAFIDI.Areas.Identity.Pages.Account;

public class RegisterModel : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; }

    public void OnGet()
    {
    }
    public async Task<IActionResult> OnPostAsync()
    {
        return Page();
    }
}
