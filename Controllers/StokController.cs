using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Muhasebe.Models;
namespace Muhasebe.Controllers
{
    public class StokController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var s = context.Stoks.ToList();
            return View(s);
        }
    }
}
