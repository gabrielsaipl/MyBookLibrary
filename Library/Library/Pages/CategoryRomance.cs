using Library.Books;

namespace Library.Pages
{
    public partial class CategoryRomance
    {
        //initialize query variable
        private List<Book> query = new List<Book>();

        //task to create table after rendering component
        protected override async Task OnAfterRenderAsync(bool FirstRender)
        {
            if (FirstRender)
            {
                query = await DefaultQueryAsync();
                StateHasChanged();
            }
        }

        //async tasks to change the table

        public async Task<List<Book>> DefaultQueryAsync()
        {
            return await Task.FromResult(query = DefaultQuery());
        }

        public async Task<List<Book>> AgeQueryAsync()
        {
            return await Task.FromResult(query = AgeQuery());
        }

        //Queries performed
        //Query to filter the books by the category romance
        public List<Book> DefaultQuery()
        {
            var db = new BookDb();
            var query = (from book in db.Books
                         where book.Category.Contains("Romance")
                         orderby book.Title ascending
                         select book).ToList();

            return query;
        }

        public List<Book> AgeQuery()
        {
            var db = new BookDb();
            var query = (from book in db.Books
                         where book.Category.Contains("Romance")
                         orderby book.ReleaseDate ascending
                         select book).ToList();
            return query;
        }
    }
}
