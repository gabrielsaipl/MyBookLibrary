using Books.API.DbContexts;
using Books.API.Entities;
using Books.API.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Globalization;
using System.Net;

namespace Books.API.Services
{
    public class BookInfoRepository : IbookRepository
    {
        private readonly BookInfoContext _context;
        public BookInfoRepository(BookInfoContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        //Get a single book
        public async Task<Book?> GetBookAsync(int bookId)
        {

            return await _context.Books.Where(b => b.Id == bookId).OrderBy(b => b.Title).FirstOrDefaultAsync();
        }
        //Get all books
        public async Task<(IEnumerable<Book>, PaginationMetadata)> GetBooksAsync(string? sort_by, int pageNumber, int pageSize)
        {
            var collection = _context.Books.OrderBy(b=>b.Title) as IQueryable<Book>;
            if (!string.IsNullOrWhiteSpace(sort_by))
            {
                sort_by = sort_by.Trim();
                if (sort_by.Contains("Age") || sort_by.Contains("age"))
                {
                    if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                    {
                        collection = collection.OrderByDescending(b => b.ReleaseDate);
                    }
                    else { collection = collection.OrderBy(b => b.ReleaseDate); }

                }
                else if (sort_by.Contains("Title") || sort_by.Contains("title"))
                {
                    if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                    {
                        collection = collection.OrderByDescending(b => b.Title);
                    }
                    else { collection = collection.OrderBy(b => b.Title); }
                }
            }

            var totalItemCount = await collection.CountAsync();

            var paginationMetadata = new PaginationMetadata(totalItemCount, pageSize, pageNumber);

            var collectionToReturn = await collection
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();
            
            return (collectionToReturn,paginationMetadata);
        }
        //Add a book to the database
        public void AddBookAsync(Book book)
        {
            _context.Books.Add(book);
        }
        //Save changes in the database
        public async Task<bool> SaveChangesAsync()
        {
           return (await _context.SaveChangesAsync() >= 1);
        }
        //Delete a book
        public void DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
        }
        //Get all the romance books
        public async Task<IEnumerable<Book>> GetRomanceBooksAsync(string? sort_by, int pageNumber, int pageSize)
        {

            var collection = _context.Books.Where(b => b.Category.Contains("Romance") || b.Category.Contains("romance")).OrderBy(b => b.Title) as IQueryable<Book>;
        if (!string.IsNullOrWhiteSpace(sort_by))
        {
            sort_by = sort_by.Trim();
            if (sort_by.Contains("Age") || sort_by.Contains("age"))
            {
                if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                {
                    collection = collection.OrderByDescending(b => b.ReleaseDate);
                }
                else { collection = collection.OrderBy(b => b.ReleaseDate); }
            }
                else if (sort_by.Contains("Title") || sort_by.Contains("title"))
                {
                    if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                    {
                        collection = collection.OrderByDescending(b => b.Title);
                    }
                    else { collection = collection.OrderBy(b => b.Title); }
                }
            }
            var collectionToReturn = await collection
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return collectionToReturn;

        }
        //Get all the fantasy books
        public async Task<IEnumerable<Book>> GetFantasyBooksAsync(string? sort_by, int pageNumber, int pageSize)
        {
            
            var collection = _context.Books.Where(b => b.Category.Contains("Fantasy") || b.Category.Contains("fantasy")).OrderBy(b => b.Title) as IQueryable<Book>;
        if (!string.IsNullOrWhiteSpace(sort_by))
            {
            sort_by = sort_by.Trim();
            if (sort_by.Contains("Age") || sort_by.Contains("age"))
            {
                if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                {
                    collection = collection.OrderByDescending(b => b.ReleaseDate);
                }
                else { collection = collection.OrderBy(b => b.ReleaseDate); }
            }
            else if (sort_by.Contains("Title") || sort_by.Contains("title"))
                {
                    if (sort_by.Contains("desc") || sort_by.Contains("Desc"))
                    {
                        collection = collection.OrderByDescending(b => b.Title);
                    }
                    else { collection = collection.OrderBy(b => b.Title); }
                }
            }
            var collectionToReturn = await collection
                 .Skip(pageSize * (pageNumber - 1))
                 .Take(pageSize)
                 .ToListAsync();

            return collectionToReturn;
        }
    }
}
