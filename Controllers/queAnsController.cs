using Microsoft.AspNetCore.Mvc;
using Teacher_Student_platform.Models.Entities;

namespace Teacher_Student_platform.Controllers
{
    public class QueAnsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View(new quesAns());
        }

        [HttpPost]
        public IActionResult Add(quesAns model)
        {
            // Handle form submission here
            // You can access model.Ques, model.Answer, etc. to get the values submitted from the form
            return RedirectToAction("Index"); // Redirect to the desired action after form submission
        }
    }
}
