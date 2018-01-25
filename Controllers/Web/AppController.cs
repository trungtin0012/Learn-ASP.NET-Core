using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet("contact")]
        public IActionResult Contact() => View();

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
        public IActionResult About() => View();
        
    }

}