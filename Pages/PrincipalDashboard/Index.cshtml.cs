using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tsmess.Pages.Principal_Dashboard
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string SelectedTab { set; get; } = "v-pills-home";
        public void OnGet(string tab)
        {
            if (!string.IsNullOrEmpty(tab))
            {
                SelectedTab = tab;
            }
        }
    }
}
