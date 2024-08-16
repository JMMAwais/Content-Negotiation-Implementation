using Microsoft.AspNetCore.Mvc;

namespace Content_Negotiation_Implementation.Controllers
{
    public class AjaxCallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
