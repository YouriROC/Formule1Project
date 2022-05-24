using F1MVC.Data;
using Formule1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Formule1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Formule1Context _context;

        public HomeController(ILogger<HomeController> logger, Formule1Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {        
            return View(_context.YearDistinct.ToList());
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
}