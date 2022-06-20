using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muhasebe.Models;
namespace Muhasebe.Controllers
{
    public class SatisController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var sts = context.Satis.ToList();
            return View(sts);
        }
        [HttpGet]
        public IActionResult saveSatis()
        {
            return View();
        }
        [HttpPost]
        public IActionResult saveSatis(Satis satis)
        {
            context.Satis.Add(satis);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
