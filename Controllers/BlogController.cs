using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
