using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tumisugi_app.Models;
using TumisugiApp.Data;

namespace tumisugi_app.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Test()
    {
        var count = _context.TumiManagements.Count();
        return Content($"Tumi count: {count}");
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
