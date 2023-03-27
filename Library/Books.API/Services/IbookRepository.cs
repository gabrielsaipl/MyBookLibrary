using Books.API.Entities;

namespace Books.API.Services
{
    public interface IbookRepository
    {
        //api/books
        Task<(IEnumerable<Book>, PaginationMetadata)> GetBooksAsync(string? sort_by, int pageNumber, int pageSize);
        Task<Book?> GetBookAsync(int bookId);
        Task<bool> SaveChangesAsync();
        void AddBookAsync(Book book);

        void DeleteBookAsync(Book book);
        //api/books/romance
        Task<IEnumerable<Book>> GetRomanceBooksAsync(string? sort_by, int pageNumber, int pageSize);
        //api/books/fantasy
        Task<IEnumerable<Book>> GetFantasyBooksAsync(string? sort_by, int pageNumber, int pageSize);

    }
}
