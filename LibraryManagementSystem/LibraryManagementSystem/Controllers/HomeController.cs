using System.Diagnostics;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly LibraryManagementDbContext _context;

    public HomeController(ILogger<HomeController> logger, LibraryManagementDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()

    {
        List<Carousel> carousels = await _context.Carousels.ToListAsync();
        carousels.Sort((a, b) => a.Order.CompareTo(b.Order));
        TempData["Carousels"] = carousels;
        Dictionary<string, string> menu = new Dictionary<string, string>()
        {
            { "Index", "Trang chủ" },
            { "Privacy", "Tài liệu điện tử" },
            { "Materials", "Học liệu điện tử" },
            { "Boook", "Sách" },
            { "Contact", "Liên hệ" },
            { "Administration", "Quản trị" },
            { "Introduction", "Giới thiệu" },
            { "Detail", "Detail" },
        };
        var categories = await _context.Categories.ToListAsync();
        TempData["Menu"] = menu;
        TempData["Categories"] = categories;
        // TempData["ActivePage"] = "Home";
        ViewBag.Books = await _context.Books.Include(b => b.Author).Include(b => b.Category).ToListAsync();
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