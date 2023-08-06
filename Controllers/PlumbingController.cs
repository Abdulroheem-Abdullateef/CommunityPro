using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class PlumbingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
