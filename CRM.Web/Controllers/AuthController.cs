using Microsoft.AspNetCore.Mvc;

namespace CRM.Web.Controllers
{
    public class AuthController : Controller
    {
        [Route("login")]
        public IActionResult Index()
        {
            return View("Login");
        }
    }
}