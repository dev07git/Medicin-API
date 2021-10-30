using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMedicinService _medicinService;

        public HomeController(ILogger<HomeController> logger,IMedicinService medicinService)
        {
            _logger = logger;
            this._medicinService = medicinService;
        }

        public async Task<IActionResult> Index()
        {
            List<Medicin> medicins =await _medicinService.GetMedicinsAsync();
          
            ViewBag.Medicins = medicins;
            return View(medicins);
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
