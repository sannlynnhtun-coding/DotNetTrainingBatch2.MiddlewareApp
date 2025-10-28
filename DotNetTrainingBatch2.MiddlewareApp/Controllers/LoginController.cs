using DotNetTrainingBatch2.MiddlewareApp.Database.AppDbContextModels;
using DotNetTrainingBatch2.MiddlewareApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DotNetTrainingBatch2.MiddlewareApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _db;

        public LoginController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginRequestModel request)
        {
            var item = await _db.TblUsers.FirstOrDefaultAsync(x =>
                x.UserName == request.UserName &&
                x.Password == request.Password);
            var loginData = JsonConvert.SerializeObject(item);
            HttpContext.Session.SetString("Login", loginData);

            return Redirect("/Home");
        }
    }
}
