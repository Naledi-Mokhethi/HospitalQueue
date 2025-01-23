using HospitalQueue.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HospitalQueue.Class;


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
            DateTime? dateTimeNow = DateTime.Now; 
            //Node data list can be populated from here....
            List<object> patientDataList = new List<object>
            {
                model.FullNames!,
                model.LastName!,
                model.ID,
                model.PhoneNumber!,
                model.DateTime,
                model.ProblemPriority![1],
                model.ProblemPriority![0],
                model.Description
            };  
            //Passing the value of the selected Priority
            int selectedPriority = model.SelectedPriority;

            var myPriorityQueue = new PriorityQueue();
            myPriorityQueue.MaxEnqueue(patientDataList, selectedPriority);

            return View(model);// the number will be returned by the custom UI so return index after response 
        }


    }
}
