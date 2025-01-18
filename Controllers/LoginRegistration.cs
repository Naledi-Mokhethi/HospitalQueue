using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalQueue.Controllers
{
    public class LoginRegistration : Controller
    {
        // GET: LoginRegistration
        public IActionResult ER_Registration()
        {
            return View();
        }
    }
}
