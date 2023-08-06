using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
