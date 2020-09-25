using Braintree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using braintree_aspnetcore_example.Models;

namespace braintree_aspnetcore_example.Controllers
{
    public class CheckoutsController : Controller
    {

        private readonly BraintreeGateway gateway = new BraintreeGateway
            {
                Environment = Braintree.Environment.ParseEnvironment(Startup.BraintreeSettings["Environment"]),
                MerchantId = Startup.BraintreeSettings["MerchantId"],
                PublicKey = Startup.BraintreeSettings["PublicKey"],
                PrivateKey = Startup.BraintreeSettings["PrivateKey"]
            };

        private readonly ILogger<CheckoutsController> _logger;

        public CheckoutsController(ILogger<CheckoutsController> logger)
        {
            _logger = logger;
        }

        public IActionResult New()
        {
            ViewData["ClientToken"] = gateway.ClientToken.Generate();
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
