using BookmateApp.DTOs.Responses;

namespace BookmateApp.Mvc.Models;

public class BookCollection
{
    public List<BookListItem> BookListItems { get; set; } = new List<BookListItem>();
    public void ClearAll() => BookListItems.Clear();
    public int TotalBookRates() => BookListItems.Sum(item => (int)item.Book.Rate);
    public double AvarageBookRates() => (double) TotalBookRates() / BookListItems.Count;

    public void AddBook(BookListItem bookListItem)
    {
        var exists = BookListItems.FirstOrDefault(b => b.Book.Id == bookListItem.Book.Id);
        if(exists is not null)
            bookListItem.IsAdded = true;
        else
        {
            BookListItems.Add(bookListItem);
        }
    }
}
public class BookListItem
{ 
    public BookDisplayResponse Book { get; set; }
    public bool? IsRead { get; set; }
    public bool? IsAdded { get; set; }
}