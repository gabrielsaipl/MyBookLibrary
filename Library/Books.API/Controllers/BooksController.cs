using AutoMapper;
using Books.API.Entities;
using Books.API.Models;
using Books.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Books.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IbookRepository _bookInfoRepository;
        private readonly IMapper _mapper;
        const int maxPageSize = 20;

        public BooksController(IbookRepository bookInfoRepository, IMapper mapper) 
        {
            _bookInfoRepository = bookInfoRepository ?? throw new ArgumentNullException(nameof(bookInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Get all the books
        /// </summary>
        /// <param name="sort_by">option to sort the list</param>
        /// <param name="pageNumber">option to include the page number</param>
        /// <param name="pageSize">option to include the page size (max is 16)</param>
        /// <returns>An IEnumerable of BookDto</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks([FromQuery] string? sort_by, int pageNumber = 1, int pageSize = 15)
        {
            if (pageSize > maxPageSize) 
            {
                pageSize = maxPageSize;
            }
            var (bookEntities, paginationMetadata) = await _bookInfoRepository.GetBooksAsync(sort_by, pageNumber, pageSize);

            Response.Headers.Add("X-Pagination", System.Text.Json.JsonSerializer.Serialize(paginationMetadata));


            return Ok(_mapper.Map<IEnumerable<BookDto>>(bookEntities));
            

        }
        /// <summary>
        /// Get a book with a specific Id
        /// </summary>
        /// <param name="id">The Id of the book</param>
        /// <returns>An IActionResult</returns>
        /// <response code = "200">Returns the requested book</response>
        [HttpGet("{id}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBook(int id)
        {
            
            var book = await _bookInfoRepository.GetBookAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<BookDto>(book));
           
        }
        /// <summary>
        /// Create a new book
        /// </summary>
        /// <param name="book">The book to add to the database</param>
        /// <returns>An ActionResult of BookDto</returns>
        [HttpPost]
        public async Task<ActionResult<BookDto>> CreateBook(BookDto book)
        {

            var finalBook = _mapper.Map<Entities.Book>(book);

            _bookInfoRepository.AddBookAsync(finalBook);

            await _bookInfoRepository.SaveChangesAsync();

            var createdBookToReturn = _mapper.Map<Models.BookDto>(finalBook);
            
            return CreatedAtRoute("GetBook",
                new 
            {
                id = createdBookToReturn.Id,
            }, 
                createdBookToReturn);
            
        }
        /// <summary>
        /// Update a book
        /// </summary>
        /// <param name="Bookid">The Id of the book to modify</param>
        /// <param name="book">The book entity to modify</param>
        /// <returns>An ActionResult</returns>
        [HttpPut("{bookid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateBook(int Bookid, BookForUpdateDto book)
        {

            var bookEntity = await _bookInfoRepository.GetBookAsync(Bookid);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(book, bookEntity);

            await _bookInfoRepository.SaveChangesAsync();

            return NoContent();
         

        }
        /// <summary>
        /// update specific atributes of a book
        /// </summary>
        /// <param name="Bookid">The Id of the book to modify</param>
        /// <param name="patchDocument"> variable containing the patch operations to complete</param>
        /// <returns>An ActionResult</returns>
        [HttpPatch("{bookid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> PartiallyUpdateBook(int Bookid, JsonPatchDocument<BookForUpdateDto> patchDocument)
        {

            var bookEntity = await _bookInfoRepository.GetBookAsync(Bookid);
            if (bookEntity == null)
            {
                return NotFound();
            }

            var bookToPatch = _mapper.Map<BookForUpdateDto>(bookEntity);

            patchDocument.ApplyTo(bookToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!TryValidateModel(bookToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(bookToPatch, bookEntity);

            await _bookInfoRepository.SaveChangesAsync();

            return NoContent();

            
        }
        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="Bookid">The Id of the book to delete</param>
        /// <returns>ActionResult</returns>
        [HttpDelete("{bookid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeletePointOfInterest(int Bookid)
        {
            var bookEntity = await _bookInfoRepository.GetBookAsync(Bookid);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _bookInfoRepository.DeleteBookAsync(bookEntity);

            _bookInfoRepository.SaveChangesAsync();

            return NoContent();
           
        }
        /// <summary>
        /// Get all the books that have "romance" in the category
        /// </summary>
        /// <param name="sort_by">option to sort the list</param>
        /// <param name="pageNumber">option to include the page number</param>
        /// <param name="pageSize">option to include the page size (max is 16)</param>
        /// <returns></returns>
        [HttpGet("romance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetRomanceBooks(string? sort_by, int pageNumber = 1, int pageSize = 10)
        {

            var bookEntities = await _bookInfoRepository.GetRomanceBooksAsync(sort_by, pageNumber, pageSize);

            return Ok(_mapper.Map<IEnumerable<BookDto>>(bookEntities));
           

        }
        /// <summary>
        /// Get all the books that have "fantasy" in the category
        /// </summary>
        /// <param name="sort_by">option to sort the list</param>
        /// <param name="pageNumber">option to include the page number</param>
        /// <param name="pageSize">option to include the page size (max is 16)</param>
        /// <returns></returns>
        [HttpGet("fantasy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetFantasyBooks(string? sort_by, int pageNumber = 1, int pageSize = 10)
        {

            var bookEntities = await _bookInfoRepository.GetFantasyBooksAsync(sort_by, pageNumber, pageSize);

            return Ok(_mapper.Map<IEnumerable<BookDto>>(bookEntities));
           

        }
    }
}
