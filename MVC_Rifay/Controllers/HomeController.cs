using Microsoft.AspNetCore.Mvc;
using MVC_Rifay.Models;
using System.Diagnostics;

namespace MVC_Rifay.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult about()
		{
			return View();
		}
        public IActionResult accomodation()
        {
            return View();
        }
        public IActionResult gallery()
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