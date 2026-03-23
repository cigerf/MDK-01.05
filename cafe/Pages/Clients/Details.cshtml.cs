using cafe.Data;
using cafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafe.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

            public DetailsModel(ApplicationDbContext context)
            {
                _context = context;
            }
        public Clients Clients { get; set; }

        public IActionResult OnGet(int id)
        {
            Clients = _context.Clients.FirstOrDefault(b => b.Id == id);

            if (Clients == null)
                return NotFound();

            return Page();
        }
    }
}
