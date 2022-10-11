using Microsoft.AspNetCore.Mvc;

namespace LibraOCR.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
