using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Controllers
{
    public class Backoffice : Controller
    {

        public IActionResult Password()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
