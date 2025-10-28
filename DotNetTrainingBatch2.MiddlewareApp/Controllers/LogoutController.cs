using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch2.MiddlewareApp.Controllers
{
    public class LogoutController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return Redirect("/Login");
        }
    }
}
