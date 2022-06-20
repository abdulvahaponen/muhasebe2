using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Muhasebe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Muhasebe.Models;
namespace Muhasebe.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();   
        public IActionResult Index()
        {
            var ftr = context.Faturas.ToList();
            return View(ftr);
        }
        [HttpGet]
        public IActionResult saveFatura()
        {
            return View();
        }
        [HttpPost]
        public IActionResult saveFatura(Fatura fatura)
        {
            context.Faturas.Add(fatura);
            context.SaveChanges();
            return RedirectToAction("Index");
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
