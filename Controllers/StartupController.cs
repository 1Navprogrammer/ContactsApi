using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    public class StartupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}