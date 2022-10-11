using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreOCR.Website.Controllers
{
    public class HandleController : Controller
    {
        public IActionResult FileProcessing(IFormFile file)
        {

            
            return View();
        }
    }
}
