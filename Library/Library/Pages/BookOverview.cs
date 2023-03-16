using Library.Books;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
//used to contain code now in the Index.cs class
namespace Library.Pages
{
    public partial class BookOverview
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
        //Query to order the books by name
        public List<Book> DefaultQuery()
        {
            var db = new BookDb();
            var query = (from book in db.Books
                         orderby book.Title ascending
                         select book).ToList();

            return query;
        }
        //Query to order the books by age
        public List<Book> AgeQuery()
        {
            var db = new BookDb();
            var query = (from book in db.Books
                         orderby book.ReleaseDate ascending
                         select book).ToList();
            return query;
        }
    }
}
