using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAsp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}