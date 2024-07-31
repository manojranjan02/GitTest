using Microsoft.AspNetCore.Mvc;

namespace GitTest.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> UserAccount()
        {
            return View();
        }
    }
}
