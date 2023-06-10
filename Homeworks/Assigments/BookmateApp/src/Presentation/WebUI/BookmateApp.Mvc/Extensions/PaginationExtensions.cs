using BookmateApp.DTOs.Responses;
using BookmateApp.Mvc.Models;

namespace BookmateApp.Mvc.Extensions;

public static class PaginationExtensions
{
    public static PaginationBookViewModel CreatePagination(this IEnumerable<BookDisplayResponse> books, int pageNo)
    {
        
            /*
             * 1. Sayfa:
             * 0 eleman atla 8 eleman al
             * 
             * 2. Sayfa:
             * 8 eleman atla 8 eleman al
             * 
             * 3. sayfa:
             * 16 eleman atla 8 eleman al
             */
            /*Kursların toplam sayfa sayısı için hangi bilgiler gerekli?
             * 
             * 1. Sayfada kaç kurs olacak? ,
             * 2. Toplam kaç kurs var? 
             */
            var booksPerPage = 4;
            var booksCount = books.Count();
            var totalPage = Math.Ceiling((decimal)booksCount / booksPerPage);

            var pagingInfo = new PagingInfoModel
            {
                CurrentPage = pageNo,
                ItemsPerPage = booksPerPage,
                TotalItems = booksCount
            };



            var paginatedBooks = books.OrderBy(c => c.Id)
                                          .Skip((pageNo - 1) * booksPerPage)
                                          .Take(booksPerPage)
                                          .ToList();

            var model = new PaginationBookViewModel
            {
                Books = paginatedBooks,
                PagingInfoModel = pagingInfo
            };

            return model;
    }
}