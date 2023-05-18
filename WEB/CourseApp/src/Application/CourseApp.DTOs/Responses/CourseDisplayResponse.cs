using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CourseApp.DTOs.Responses
{
    public class CourseDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Title { get; set; }
        public string? ImageUrl { get; set; } = "https://picsum.photos/200/200";
        public decimal Price { get; set; }
        public byte? Rating { get; set; }
    }
}
