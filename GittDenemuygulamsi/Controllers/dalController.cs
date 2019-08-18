using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GittDenemuygulamsi.Controllers
{
    public class dalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}