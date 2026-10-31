using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Uber_Presentation_Layer.Common;

namespace Uber_Presentation_Layer.Controllers
{
    public class PassengerController : Controller
    {
        [Authorize(Roles = RoleApp.Passenger)]
        public IActionResult Index()
        {
            return View();
        }

    }
}
