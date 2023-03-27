using Library.Books;
using Library.Services;
using Microsoft.AspNetCore.Components;
using System.Security.Policy;

namespace Library.Pages
{
    public partial class BookDetail
    {
        [Parameter]
        public string Id { get; set; }
        protected bool Saved;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        private HttpResponseMessage responseMessage;
        public Book Book { get; set; } = new Book();
        [Inject]
        public IBookDataService BookDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Book = await BookDataService.GetBookAsync(Id);
            Saved = false;
           
        }

        protected async Task DeleteBook()
        {
            if (int.Parse(Id) <= 10)
            {
                StatusClass = "alert-danger";
                Message = "You can't delete my Books !!!!";
                Saved = true;
            }
            else
            {
                responseMessage = await BookDataService.DeleteBookAsync(Id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    StatusClass = "alert-success";
                    Message = "Book deleted successfully.";
                    Saved = true;
                }
                else {
                    StatusClass = "alert-success";
                    Message = "Couldnt delete book.";
                    Saved = true;
                }
            }
        }
        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/books");
        }
    }
}