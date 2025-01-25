using HospitalQueue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HospitalQueue.Class;


namespace HospitalQueue.Controllers
{
    public class ErRegistrationController : Controller
    {

        // GET: LoginRegistration
        [HttpGet]
        public IActionResult ErRegistration()
        {

            var problemPriority = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Unconscious"),
                new KeyValuePair<int, string>(2, "Penetrating trauma (Stab or Gunshot)"),
                new KeyValuePair<int, string>(3, "Pains (Chest and test)"),
                new KeyValuePair<int, string>(4, "Foreign Object")
            };

            var viewModel = new ErRegistration
            {
                ProblemPriority = problemPriority
            };
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult ErRegistration(ErRegistration model)
        {
            //Node data list can be populated from here....
            model.DateTime = DateTime.Now;  
            List<object> patientDataList = new List<object>
            {
                model.FullNames!,
                model.LastName!,
                model.ID,
                model.PhoneNumber!,
                model.DateTime,
                model.SelectedPriority,
                model.Description
            };  
            //Passing the value of the selected Priority
            int selectedPriority = model.SelectedPriority;

            var myPriorityQueue = new PriorityQueue();
            myPriorityQueue.MaxEnqueue(patientDataList, selectedPriority);

            return View("Home/Index");// the number will be returned by the custom UI so return index after response 
        }
    }

}
