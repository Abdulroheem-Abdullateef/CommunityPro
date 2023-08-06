using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class FarmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
