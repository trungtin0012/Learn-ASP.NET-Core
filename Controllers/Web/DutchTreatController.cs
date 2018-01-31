using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Services;
using HelloWorld.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers.Web
{
    public class DutchTreatController : Controller
    {
        private readonly IMailServices _mailServices;

        public DutchTreatController(IMailServices mailServices)
        {
            _mailServices = mailServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact us";

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                _mailServices.SendMessage(model.Email, model.Subject, model.Message);
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear();
            }
            else
            {

            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About us";
            return View();
        }

    }
}