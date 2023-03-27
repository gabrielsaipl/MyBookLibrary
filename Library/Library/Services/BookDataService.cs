using Library.Books;
using System.Text.Json;

namespace Library.Services
{
    public class BookDataService : IBookDataService
    {
        private readonly HttpClient _httpClient;

        public BookDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> AddBookAsync(JsonContent book)
        {
            HttpResponseMessage response = await _httpClient.PostAsync($"api/books", book);
            return response;
        }

        public async Task<HttpResponseMessage?> DeleteBookAsync(string bookId)
        {
            HttpResponseMessage response = _httpClient.DeleteAsync($"api/books/{bookId}").Result;
            return response;
        }

        public async Task<Book?> GetBookAsync(string bookId)
        {
            return await JsonSerializer.DeserializeAsync<Book>(await _httpClient.GetStreamAsync($"api/books/{bookId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetBooksByAgeAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books?sort_by=age"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetBooksByAgeDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books?sort_by=age(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetBooksByTitleDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books?sort_by=title(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetFantasyBooksAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/fantasy"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetFantasyBooksByAgeAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/fantasy?sort_by=age"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetFantasyBooksByAgeDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/fantasy?sort_by=age(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetFantasyBooksByTitleDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/fantasy?sort_by=title(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetRomanceBooksAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/romance"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetRomanceBooksByAgeAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/romance?sort_by=age"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetRomanceBooksByAgeDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/romance?sort_by=age(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<IEnumerable<Book>> GetRomanceBooksByTitleDescAsync()
        {
            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(await _httpClient.GetStreamAsync($"api/books/romance?sort_by=title(desc)"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<HttpResponseMessage> UpdateBook(string bookId, JsonContent book)
        {
            HttpResponseMessage response = await _httpClient.PutAsync($"api/books/{bookId}", book);
            return response;
        }
    }
}
