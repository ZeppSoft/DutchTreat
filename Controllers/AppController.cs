using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;
        //private readonly DutchContext _context;

        public AppController(IMailService mailService, /*DutchContext context*/ IDutchRepository repository)
        {
            this._mailService = mailService;
            this._repository = repository;
            //this._context = context;
        }
        public IActionResult Index()
        {
            //throw new InvalidProgramException("Some bad things happened!");
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
           // throw new InvalidProgramException("Some bad things happened!");
            return View();
        }
         
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send the email
                _mailService.SendMessage(model.Email, model.Subject, model.Message);
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                //show the errors
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
        public IActionResult Shop()
        {
            //var results = _context.Products
            //    .OrderBy(p=>p.Category)
            //    .ToList();

            var results = _repository.GetAllProducts();

            return View(results);
        }
    }
}
