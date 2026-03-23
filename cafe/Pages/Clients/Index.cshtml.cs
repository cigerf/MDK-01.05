using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cafe.Models;
using cafe.Data;

namespace cafe.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Clients> Clients { get; set; }

        public void OnGet()
        {
            Clients = _context.Clients.ToList();
        }
    }
}
