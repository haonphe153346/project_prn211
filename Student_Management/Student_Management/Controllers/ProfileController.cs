using Microsoft.AspNetCore.Mvc;

namespace Student_Management.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
