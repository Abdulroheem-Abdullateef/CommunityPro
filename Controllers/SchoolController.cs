using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
