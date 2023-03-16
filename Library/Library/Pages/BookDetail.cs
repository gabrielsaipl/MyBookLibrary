using Library.Books;
using Microsoft.AspNetCore.Components;
using System.Security.Policy;

namespace Library.Pages
{
    public partial class BookDetail
    {
        [Parameter]
        public string ISBN { get ; set; }
        protected bool Saved;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        public Book Book { get; set; } = new Book();

        protected override Task OnInitializedAsync()
        {
            Saved = false;  
            var db = new BookDb();
            Book = db.Books.FirstOrDefault(b => b.ISBN == ISBN);
            return base.OnInitializedAsync();
        }

        protected async Task DeleteBook()
        {
            var db = new BookDb();
            Book = db.Books.FirstOrDefault(b => b.ISBN == ISBN);
            if (Book.Id <= 10)
            {
                StatusClass = "alert-danger";
                Message = "You can't delete my Books !!!!";
                Saved = true;
            }
            else
            {
                Saved = false;
                db.Books.Remove(Book);
                db.SaveChanges();
                StatusClass = "alert-success";
                Message = "Book deleted successfully.";
                Saved = true;
            }
        }
        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/books");
        }
    }
}
