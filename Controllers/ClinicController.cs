using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class ClinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
