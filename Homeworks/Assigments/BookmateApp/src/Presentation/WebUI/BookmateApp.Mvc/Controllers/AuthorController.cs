using Azure.Core;
using BookmateApp.DTOs.Requests;
using BookmateApp.Services.ServiceImplementations;
using BookmateApp.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookmateApp.Mvc.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return View(authors);
        }
        public IActionResult CreateAuthor()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorRequest createAuthorRequest)
        {
            if (ModelState.IsValid)
            {
                await _authorService.CreateAuthorAsync(createAuthorRequest);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
