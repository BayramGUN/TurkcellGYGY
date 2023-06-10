using BookmateApp.DTOs.Requests;
using BookmateApp.DTOs.Responses;
using BookmateApp.Entities;
using BookmateApp.Mvc.Models;
using BookmateApp.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookmateApp.Mvc.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IGenreService _genreService;

        public BookController(
                IBookService bookService, 
                IAuthorService authorService, 
                IGenreService genreService
            )
        {
            _bookService = bookService;
            _authorService = authorService;
            _genreService = genreService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllBooksAsync();
            return View(books);
        }

        public async Task<IActionResult> CreateBook()
        {

            var createBookViewModel = await createBookViewModelGenerator();

            return View(createBookViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var bookForForUpdate = await _bookService.GetBookForUpdateAsync(id);
            return View(bookForForUpdate);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, UpdateBookRequest updateBookRequest)
        {
            if (await _bookService.IsBookExist(id))
            {
                if (ModelState.IsValid)
                {
                    await _bookService.UpdateBookAsync(updateBookRequest);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            return NotFound();
        }
        private async Task<CreateBookViewModel> createBookViewModelGenerator()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            var genres = await _genreService.GetAllGenresAsync();
            CreateBookViewModel createBookViewModel = new CreateBookViewModel
            {
                Request = new DTOs.Requests.CreateBookRequest(),
                AuthorItems = authors.Select(a => new SelectListItem { Text = a.FullName, Value = a.Id.ToString() }),
                GenreItems = genres.Select(g => new SelectListItem { Text = g.Name, Value = g.Id.ToString() }),
            };
            return createBookViewModel;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookRequest request)
        {
            if(ModelState.IsValid)
            {
                await _bookService.CreateBookAsync(request);
                return RedirectToAction("Index");
            }
            var createBookViewModel = await createBookViewModelGenerator();
            return View(createBookViewModel); 
           
        }
    }
}
