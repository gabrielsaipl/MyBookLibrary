using Library.Books;
using Library.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json.Serialization;

namespace Library.Pages
{
    public partial class BookCreate
    {
        public Book Book { get; private set; } = new Book();
        protected string Message = string.Empty;
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        [Inject]
        public IBookDataService BookDataService { get; set; }
        protected string StatusClass= string.Empty;
        private HttpResponseMessage responseMessage;
        protected bool Saved;

       /* protected override Task OnInitializedAsync()
        {
            Saved = false;
             Book = new Book
             {
                 ISBN = "0",
                 Title = "",
                 Description = "",
                 ReleaseDate = "",
                 Category = ""
             };

            return base.OnInitializedAsync();
        }*/

        private IReadOnlyList<IBrowserFile> selectedFiles;
        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();

        }

        protected async Task HandleValidSubmit()
        {
            JsonContent content = JsonContent.Create(Book);
            responseMessage = await BookDataService.AddBookAsync(content);
            if (responseMessage.IsSuccessStatusCode)
            {
                //saving the file to the images folder
                if (selectedFiles != null)
                {
                    var file = selectedFiles[0];
                    var fileName = Path.GetFileName(file.Name);
                    Stream stream = file.OpenReadStream();
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", Path.GetFileName(file.Name));
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                    var imageName = $"{Directory.GetCurrentDirectory()}\\wwwroot\\images\\image{Book.Id.ToString()}.jpg";
                    File.Move(filePath, imageName);
                }

                StatusClass = "alert-success";
                Message = "New book added successfully.";
                Saved = true;
            }
            else
            {
                StatusClass = "alert-danger";
                Message = "Book not edited successfully.";
                Saved = true;
            }
        }
        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/books");
        }
    }
}
