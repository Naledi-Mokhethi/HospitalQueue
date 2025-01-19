using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalQueue.Controllers
{
    public class RegistrationLogin : Controller
    {
        // GET: LoginRegistration
        public IActionResult ER_Registration()
        {
            return View();
        }
    }
}
