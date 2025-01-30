using HospitalQueue.Class;
using HospitalQueue.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace HospitalQueue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>? _logger;
        private readonly PriorityQueue? _myPriorityQueue;

        public HomeController(ILogger<HomeController> logger, PriorityQueue myPriorityQueue)
        {
            _logger = logger;

            _myPriorityQueue = myPriorityQueue;
        }

        public IActionResult Index()
        {
            // we call the peak and access its members then pass them to the view
            if (_myPriorityQueue!.head != null)
            {
              
                return View("Index",_myPriorityQueue.Peek());
            }
            return View("Index","No One");
        }

         
        public IActionResult ER_Registration()
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
