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
            var quadrantsValues = _context.Quadrent1s
                .Include(q => q.Type) // Ensure related Type data is loaded
                .ToList();

            return View(quadrantsValues);
        }

        
        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Type = _context.Type.ToList();
        
            return View("AddTask", new Quadrent1());
        }
        
        [HttpPost]
        public IActionResult AddTask(Quadrent1 response)
        {
            _context.Quadrent1s.Add(response);
            _context.SaveChanges();
            return View("ConfirmationPage", response);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var taskRecord = _context.Quadrent1s
                .Single(x => x.Q1Id == id);
        
            ViewBag.Type = _context.Type.ToList();
            return View("AddTask", taskRecord);
        }
        
        [HttpPost]
        public IActionResult Edit(Quadrent1 updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("Quadrants");
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Quadrent1s
                .Single(x => x.Q1Id == id);
        
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Quadrent1 deletedRecord)
        {
            _context.Quadrent1s.Remove(deletedRecord);
            _context.SaveChanges();
        
            return RedirectToAction("Quadrants");
        }
        
        [HttpPost]
        public IActionResult ToggleComplete(int taskId)
        {
            var task = _context.Quadrent1s.FirstOrDefault(t => t.Q1Id == taskId);
            if (task != null)
            {
                task.TruFalse = !task.TruFalse;
                _context.SaveChanges();
            }
            return RedirectToAction("Quadrants");
        }
    }
}

        
           
       
       
        
    
