using Library.Books;
using Library.Services;
using Microsoft.AspNetCore.Components;

namespace Library.Pages
{
    public partial class CategoryFantasy
    {
        //initialize Book variables
        private List<Book> Books { get; set; } = new List<Book>();
        private List<Book> Books1 { get; set; } = new List<Book>();
        private List<Book> Books2 { get; set; } = new List<Book>();
        private int counter2 = 0;
        private List<Book> Books3 { get; set; } = new List<Book>();
        private int counter3 = 0;
        private List<Book> Books4 { get; set; } = new List<Book>();
        private int counter4 = 0;

        [Inject]
        public IBookDataService BookDataService { get; set; }

        //task to create table after rendering component
        /*protected async override Task OnInitializedAsync()
        {
            Books = (await BookDataService.GetBooksAsync()).ToList();

        }*/
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Books = (await BookDataService.GetFantasyBooksAsync()).ToList();
                Books1 = Books;
                StateHasChanged();
            }

        }

        private async Task<List<Book>> OrderByTitleAscending()
        {
            Books = Books1;
            return Books;
        }
        private async Task<List<Book>> OrderByTitleDescending()
        {

            if (counter2 == 0)
            {
                Books2 = (await BookDataService.GetFantasyBooksByTitleDescAsync()).ToList();
                counter2++;
            }
            Books = Books2;
            return Books;
        }
        private async Task<List<Book>> OrderByAgeAscending()
        {
            if (counter3 == 0)
            {
                Books3 = (await BookDataService.GetFantasyBooksByAgeAsync()).ToList();
                counter3++;
            }
            Books = Books3;
            return Books;
        }

        private async Task<List<Book>> OrderByAgeDescending()
        {
            if (counter4 == 0)
            {
                Books4 = (await BookDataService.GetFantasyBooksByAgeDescAsync()).ToList(); ;
                counter4++;
            }
            Books = Books4;
            return Books;
        }



    }
}
