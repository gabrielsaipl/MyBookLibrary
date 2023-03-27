using Library.Books;
using Microsoft.AspNetCore.Mvc;

namespace Library.Services
{
    public interface IBookDataService
    {
        //api/books
        //GET
        Task<IEnumerable<Book>> GetBooksAsync();
        //GET
        Task<IEnumerable<Book>> GetBooksByTitleDescAsync();
        //GET
        Task<IEnumerable<Book>> GetBooksByAgeAsync();
        //GET
        Task<IEnumerable<Book>> GetBooksByAgeDescAsync();
        //GET
        Task<Book?> GetBookAsync(string bookId);
        //POST
        Task<HttpResponseMessage> AddBookAsync(JsonContent book);
        //PUT
        Task<HttpResponseMessage> UpdateBook(string bookId, JsonContent book);
        //DELETE
        Task<HttpResponseMessage?> DeleteBookAsync(string bookId);
        //api/books/romance
        //GET
        Task<IEnumerable<Book>> GetRomanceBooksAsync();
        //GET
        Task<IEnumerable<Book>> GetRomanceBooksByTitleDescAsync();
        //GET
        Task<IEnumerable<Book>> GetRomanceBooksByAgeAsync();
        //GET
        Task<IEnumerable<Book>> GetRomanceBooksByAgeDescAsync();
        //api/books/fantasy
        //GET
        Task<IEnumerable<Book>> GetFantasyBooksAsync();
        //GET
        Task<IEnumerable<Book>> GetFantasyBooksByTitleDescAsync();
        //GET
        Task<IEnumerable<Book>> GetFantasyBooksByAgeAsync();
        //GET
        Task<IEnumerable<Book>> GetFantasyBooksByAgeDescAsync();
    }
}
