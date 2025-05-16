using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers
{
    public class AdminController : Controller
    {

      
        public async Task<IActionResult> Index()
        {
           
            return View();
        }
        
        
                     
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Book model)
        {
            return View();
        }

        public IActionResult Edit(int id) => View();      // Show edit form

        [HttpPost]
        public IActionResult Edit(Book model)
        {
            return View();
        }

        public IActionResult Delete(int id) { /* Delete logic */ return RedirectToAction("Index"); }
        
    }
}
