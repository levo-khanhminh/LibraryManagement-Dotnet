using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers;

public class CategoryController : Controller

{
    private readonly LibraryManagementDbContext _context;

    public CategoryController(LibraryManagementDbContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Books(int id)
    {
        // List<Carousel> carousels =  _context.Carousels.ToList();
        // carousels.Sort((a, b) => a.Order.CompareTo(b.Order));
        // TempData["Carousels"] = carousels;
        var categories = _context.Categories.ToList();
        var category = _context.Categories
            .Include(c => c.Books) // ✅ now this works
            .ThenInclude(b => b.Author) // if you want author info
            .FirstOrDefault(c => c.CategoryId == id);
        ViewBag.Category = category;
        TempData["Categories"] = categories;
        // TempData["ActivePage"] = category.Name;
        return View();
    }
}