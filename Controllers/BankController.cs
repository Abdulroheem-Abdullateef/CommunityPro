using Microsoft.AspNetCore.Mvc;

namespace CommunityProApp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
