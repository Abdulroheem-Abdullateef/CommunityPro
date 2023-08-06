using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class EstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
