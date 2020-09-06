using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;
using dal;
using dal.ORM.EFCore;
using Microsoft.EntityFrameworkCore;
using entities.tables;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  WCdBContext db;

        public HomeController(ILogger<HomeController> logger,WCdBContext con)
        {
            _logger = logger;
            db = con;

        }

        public IActionResult Index()
        {
            Menus m = new Menus();
            m.menuAd = "sss";
            m.ustId = 0;
           

          

                db.Add(m);
            db.SaveChanges();
               
                
                
                string s = "welat";
           
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
    }
}
