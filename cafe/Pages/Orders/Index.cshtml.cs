using cafe.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace cafe.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context) => _context = context;

        public IList<cafe.Models.Orders> Orders { get; set; } = new List<cafe.Models.Orders>();

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
        }
    }
}