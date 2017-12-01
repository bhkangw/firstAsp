using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAsp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGetAttribute]
        [Route("/{fname}/{lname}/{age}/{color}")]
        public JsonResult Index(string fname, string lname, string age, string color)
        {
            return Json(new {FirstName = fname, LastName = lname, Age = age, FavoriteColor = color});
        }
    }
}