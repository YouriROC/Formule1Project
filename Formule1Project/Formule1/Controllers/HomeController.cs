using F1MVC.Data;
using F1Lib.Models;
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
            var result = _context.Results.GroupBy(a => a.Year)
                        .Select(g => new { g.Key, Count = g.Count() });
            List<IndexVm> races = new List<IndexVm>();
            foreach (var item in result)
            {
                IndexVm indexVm = new IndexVm();
                indexVm.Year = item.Key;
                indexVm.Races = item.Count;
                races.Add(indexVm);
                Console.WriteLine(item.Key + " - " + item.Count);
            }

            return View(races);
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