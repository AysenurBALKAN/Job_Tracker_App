using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Tracker.Areas.Member.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
