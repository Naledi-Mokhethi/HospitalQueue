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
                new KeyValuePair<int, string>(1, "Unconscious"),
                new KeyValuePair<int, string>(2, "Penetrating trauma (Stab or Gunshot)"),
                new KeyValuePair<int, string>(3, "Pains (Chest and Body)"),
                new KeyValuePair<int, string>(4, "Foreign Object")
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
            //Node data list can be populated from here....
            int selectedPriority = model.SelectedPriority;
            model.DateTime = DateTime.Now;
    
            return View(model);// redirect to return the number
        }


    }
}
