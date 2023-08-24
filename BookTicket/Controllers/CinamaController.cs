using BookTicket.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookTicket.Controllers
{
    public class CinamaController : Controller
    {
        private readonly AppDbContext _context;

        public CinamaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinamas = await _context.Cinama.ToListAsync();
            return View(allCinamas);
        }
    }
}
