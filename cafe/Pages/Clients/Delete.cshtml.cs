using cafe.Data;
using cafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cafe.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public cafe.Models.Clients Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null) return NotFound();
            Client = client;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}