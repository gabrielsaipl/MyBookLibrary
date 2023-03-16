using Library.Books;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Library.Pages
{
    public partial class BookCreate
    {
        public Book Book { get; private set; }
        protected string Message = string.Empty;
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        protected string StatusClass= string.Empty;
        protected bool Saved;

        protected override Task OnInitializedAsync()
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
        }

        private IReadOnlyList<IBrowserFile> selectedFiles;
        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();

        }

        protected async Task HandleValidSubmit()
        {
            var db = new BookDb();
            Saved = false;
            db.Books.Add(Book);
            db.SaveChanges();
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
