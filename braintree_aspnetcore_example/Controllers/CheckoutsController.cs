using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using braintree_aspnetcore_example.Models;

namespace braintree_aspnetcore_example.Controllers
{
    public class CheckoutsController : Controller
    {
        private readonly ILogger<CheckoutsController> _logger;

        public CheckoutsController(ILogger<CheckoutsController> logger)
        {
            _logger = logger;
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Show()
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
