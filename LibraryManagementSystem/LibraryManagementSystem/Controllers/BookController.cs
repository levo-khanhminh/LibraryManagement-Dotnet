using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers;

public class BookController : Controller
{
    private readonly LibraryManagementDbContext _context;
    public BookController(LibraryManagementDbContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(int id)
    {
        var book = _context.Books.Include(b => b.Category).Include(b => b.Author).FirstOrDefault(b => b.BookId ==  id);
        ViewBag.Book = book;
        var categories = _context.Categories.ToList();
        TempData["Categories"] = categories;
        return View();
    }

    public IActionResult ReadPdf(int id)
    {
        var book = _context.Books.FirstOrDefault(b => b.BookId == id);
        var categories = _context.Categories.ToList();
        TempData["Categories"] = categories;
        var pdfFilePath = book.Pdf;
        ViewBag.PdfFilePath = pdfFilePath;
        return View();
    }
    

}