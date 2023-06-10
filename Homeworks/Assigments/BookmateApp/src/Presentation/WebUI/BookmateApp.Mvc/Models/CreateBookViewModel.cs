using BookmateApp.DTOs.Requests;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookmateApp.Mvc.Models
{
    public class CreateBookViewModel
    {
        public CreateBookRequest Request { get; set; } = new CreateBookRequest();
        public IEnumerable<SelectListItem>? AuthorItems { get; set; }
        public IEnumerable<SelectListItem>? GenreItems { get; set; }
    }
}
