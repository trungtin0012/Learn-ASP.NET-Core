using System;
using HelloWorld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Contact() => View();

        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
        public IActionResult About() => View();
        
    }

}