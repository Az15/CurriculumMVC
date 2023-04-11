using Microsoft.AspNetCore.Mvc;

namespace AppBlogCore.Areas.Cliente.Controllers
{
    public class Certificaciones : Controller
    {
        [Area("Cliente")]
        public IActionResult IndexCertifi()
        {
            return View();
        }
    }
}
