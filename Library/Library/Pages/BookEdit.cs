using Library.Books;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.VisualBasic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Migrations;

namespace Library.Pages
{
    public partial class BookEdit
    {
        [Parameter]
        public string ISBN { get; set; }
        public Book Book { get; private set; }
        protected string Message = string.Empty;
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        protected string StatusClass= string.Empty;
        protected bool Saved;

        protected override Task OnInitializedAsync()
        {

            Saved = false;
            var db = new BookDb();
            Book = db.Books.FirstOrDefault(b => b.ISBN == ISBN);
            if (Book.Id <= 10)
            {
                StatusClass = "alert-danger";
                Message = "You can't edit by books !!!";
                Saved = true;
            }
            return base.OnInitializedAsync();
        }
        private IReadOnlyList<IBrowserFile> selectedFiles;
        private void OnInputFileChange(InputFileChangeEventArgs e)
        {        
            selectedFiles = e.GetMultipleFiles();

        }



    protected async Task HandleValidSubmit()
        {
                //saving the changes in the book
                Saved = false;
                var db = new BookDb();
                db.Entry(Book).State = EntityState.Modified;
                db.SaveChanges();
                //saving the file to the images folder
                var file = selectedFiles[0];
                var fileName = Path.GetFileName(file.Name);
                Stream stream = file.OpenReadStream();
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot\images", Path.GetFileName(file.Name));
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await stream.CopyToAsync(fileStream);
                }
                var imageName = $"{Directory.GetCurrentDirectory()}\\wwwroot\\images\\image{Book.Id.ToString()}.jpg";
            if (!File.Exists(imageName))
            {
                File.Move(filePath, imageName);
            }
            else
            {
                //replace image if it already exists with the same name
                File.Delete(imageName);
                File.Move(filePath, imageName);
            }
                
                StatusClass = "alert-success";
                Message = "Book edited successfully.";
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
