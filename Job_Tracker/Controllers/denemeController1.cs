using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Tracker.Controllers
{
    public class denemeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
