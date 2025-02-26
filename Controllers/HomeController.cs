using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission8.Models;
using System;
using System.Diagnostics;
using System.Linq;
using mission8.Models;

namespace Mission8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.Quadrent1s;

            return View(tasks);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Main Quadrants view
        public IActionResult Quadrants()
        {
           
                // linq
                var quadrent1s = _context.Quadrent1s;
                    
                return View(quadrent1s); 
            
        }
    }
}

        
           
       
       
        
    
