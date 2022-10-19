using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SametYorgun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SametYorgun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if(ModelState.IsValid)
            {
                using(var c = new Context())
                {
                    c.contacts.Add(contact);
                    c.SaveChanges();
                    return RedirectToAction("Contact", "Home");
                }

            }
            else
            {
                return View();
            }
        }

        public IActionResult Blog()
        {
            using(var c = new Context())
            {
                var bloglar = c.blogs.Where(x=>x.Status==true).ToList();
                return View(bloglar);
            }
        }

        public IActionResult Projeler()
        {
            using(var c = new Context())
            {
                var projeler = c.projelers.ToList();
                return View(projeler);
            }
           
            
        }
        public IActionResult OzGecmis()
        {
            return View();
        }
    }
}
