using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Controllers
{
    public class Backoffice : Controller
    {
        public string Index()
        {
            string t = "O x e do Index";
                return t;
        }

        public string Ola()
        {
            string hello = "Hello World!";
            return hello;
        }
    }
}
