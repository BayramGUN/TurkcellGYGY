using BookmateApp.DTOs.Responses;
using BookmateApp.Mvc.Extensions;
using BookmateApp.Mvc.Models;
using BookmateApp.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookmateApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        public HomeController(
            ILogger<HomeController> logger,
            IBookService bookService
        )
        {
            _logger = logger;
            _bookService = bookService;

        }

        public async Task<IActionResult> Index(int pageNo, Guid? id = null)
        {  

            var books = (id == null) ? await _bookService.GetAllBooksAsync() :
                                       await _bookService.GetBooksByGenreAsync(id.Value);
            var model = books.CreatePagination(pageNo);

            return View(model);
        }

            /* var viewModel = responses.Select(res => new BookViewModel
            {
                Title = res.Title,
                AuthorName = res.AuthorName,
                Description = res.Description,
                Rate = res.Rate,
                CoverImageUrl = res.CoverImageUrl,
                Genre = res.Genre,
                PublishDate = res.PublishDate
            }).ToList();   */
        public async Task<IActionResult> BookDetails(Guid id)
        {  

            var book = await _bookService.GetBookByIdAsync(id);

            return View(book);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation("Something went wrong");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}