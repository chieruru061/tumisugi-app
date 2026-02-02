

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TumisugiApp.Data;

namespace TumisugiApp.Controllers
{
    public class TumiListController : Controller
    {
        private readonly AppDbContext _context;

        public TumiListController(AppDbContext context)
        {
            _context = context;
        }

        // [WIP] ViewModel作成後着手
        // Get: TumiList
        public async Task<IActionResult> Index()
        {
            var items = await _context.TumiManagements.ToListAsync();
            return View();
        }
    }
}