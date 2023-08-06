using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
