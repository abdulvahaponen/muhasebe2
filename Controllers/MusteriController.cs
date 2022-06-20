using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muhasebe.Models;
namespace Muhasebe.Controllers
{
    public class MusteriController : Controller
    {
        Context context = new Context();
       
        public IActionResult Index()
        {
            var m = context.Musteris.ToList();
            return View(m);
        }
        [HttpGet]
        public IActionResult saveMusteri()
        {
            return View();
        }
        [HttpPost]
        public IActionResult saveMusteri(Musteri m)
        {
            context.Musteris.Add(m);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
