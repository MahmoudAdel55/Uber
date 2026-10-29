using Microsoft.AspNetCore.Mvc;

namespace Uber_Presentaion_Layer.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
