using Microsoft.AspNetCore.Mvc;

namespace MVC_Rifay.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult contact()
        {
            return View();
        }
    }
}
