using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fp_stack.web.Models;
using fp_stack.core.Models;

namespace fp_stack.web.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Nome = "Rodolfo";
            ViewData["NomeDoAluno"] = $"Outro Nome {DateTime.Now}";

            return View(_context.Perguntas.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
}
