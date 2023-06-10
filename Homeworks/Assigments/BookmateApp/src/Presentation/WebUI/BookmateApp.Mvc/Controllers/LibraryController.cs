using System.Diagnostics;
using BookmateApp.DTOs.Responses;
using BookmateApp.Mvc.Extensions;
using BookmateApp.Mvc.Models;
using BookmateApp.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace BookmateApp.Mvc.Controllers;

public class LibraryController : Controller
{
    private readonly IBookService _bookService;
    private const string librarySesion = "library";
    public LibraryController(IBookService bookService)
    {
        _bookService = bookService;
    }

    public IActionResult Index()
    {
        var bookCollection =  getBookCollectionFromSession();
        return View(bookCollection);
    }

    public async Task<IActionResult> AddBook([FromQuery]Guid bookId)
    {
        Debug.WriteLine(bookId);
        BookDisplayResponse selectedBook = await _bookService.GetBookByIdAsync(bookId);
        var bookListItem = new BookListItem {
            Book = selectedBook
        };
        BookCollection bookCollection = getBookCollectionFromSession();
        bookCollection.AddBook(bookListItem);
        saveToSession(bookCollection);
        return Json(new { message = $"{selectedBook.Title} kütüphaneye eklendi"});
    }

    private BookCollection getBookCollectionFromSession()
    {
        return HttpContext.Session.GetJson<BookCollection>(librarySesion) ?? new BookCollection();
    }
    private void saveToSession(BookCollection bookCollection)
    {
        HttpContext.Session.SetJson(librarySesion, bookCollection);
    }

}