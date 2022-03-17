using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Controllers
{
    public class Backoffice : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Controlo()
        {
            return View();
        }

    }
}
