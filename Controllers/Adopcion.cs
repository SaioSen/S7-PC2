using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S7_PC2.Models;

namespace S7_PC2.Controllers
{
    public class AdopcionController : Controller
    {
        private readonly ILogger<AdopcionController> _logger;

        public AdopcionController(ILogger<AdopcionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Adopcion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adopcion(Adopcion adopcion)
        {
            Console.WriteLine(adopcion.Nombres);
            return RedirectToAction("AdopcionConfirmacion");
        }

        public IActionResult AdopcionConfirmacion()
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
