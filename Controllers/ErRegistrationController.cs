using HospitalQueue.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalQueue.Class;
using HospitalQueue.DAL;


namespace HospitalQueue.Controllers
{
    public class ErRegistrationController : Controller
    {
        private readonly PriorityQueue _myPriorityQueue;
        private readonly PatientsDAL _patientsDAL;

        public ErRegistrationController(PriorityQueue myPriorityQueue, PatientsDAL patientsDAL)
        {
            _myPriorityQueue = myPriorityQueue;
            _patientsDAL = patientsDAL;
        }

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
        [HttpGet]
        public IActionResult Dequeue()
        {
            
            _myPriorityQueue.Dequeue(_patientsDAL);
            return RedirectToAction("Index", "Home");

        }

        [HttpPost]
        public IActionResult ErRegistration(ErRegistration model)
        {
            if (ModelState.IsValid)
            {
                model.DateTime = DateTime.Now;
                List<object> patientDataList = new List<object>
            {
                model.FullNames!,
                model.LastName!,
                model.IdentityNum!,
                model.PhoneNumber!,
                model.DateTime,
                model.SelectedPriority,
                model.Description
            };
                //Passing the value of the selected Priority
                int selectedPriority = model.SelectedPriority;
                _myPriorityQueue.MaxEnqueue(patientDataList, selectedPriority);

                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("ErRegistration");
        }

    }

}
