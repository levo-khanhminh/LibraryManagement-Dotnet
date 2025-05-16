using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers;

public class BookController : Controller
{

    public BookController()
    {
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(int id)
    {
        // var book = _bookService.GetBookById(id);
        // ViewBag.Book = book;
        return View();
    }
    

}