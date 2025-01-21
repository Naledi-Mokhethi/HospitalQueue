using HospitalQueue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HospitalQueue.Controllers
{
    public class RegistrationLogin : Controller
    {
        // GET: LoginRegistration
        public IActionResult ER_Registration()
        {

            var problemPriority = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Injury"),
                new KeyValuePair<int, string>(2, "Pains"),
                new KeyValuePair<int, string>(3, "Foreign Object")
            };

            var viewModel = new ER_Registration
            {
                ProblemPriority = problemPriority
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult ER_Registration(ER_Registration model)
        {
            int selectedPriority = model.SelectedPriority;
    
            return View(model);
        }


    }
}
