using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmisison.Models;

namespace FormSubmisison.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
       [HttpPost("")]
       public IActionResult Success(User form)
       {
           if(ModelState.IsValid)
           {
                return Redirect("Index");
           }
           return View("Success");
       }
    }
}
