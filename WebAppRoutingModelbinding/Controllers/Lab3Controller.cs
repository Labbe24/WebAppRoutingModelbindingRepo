using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppRoutingModelbinding.Models;

namespace WebAppRoutingModelbinding.Controllers
{
    public class Lab3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(PersonBindingModel person)
        {
            return Content(string.Format($"Name={person.Name}, Age={person.Age}, Height={person.Height}"));
        }
    }
}
