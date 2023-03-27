using Books.API.Models;

namespace Books.API
{
    public class BooksDataStore
    {
        public List<BookDto> Books { get; set; }

        public static BooksDataStore Current { get; } = new BooksDataStore();

        public BooksDataStore() 
        {
            Books = new List<BookDto>()
            {
                new BookDto()
                {
                    Id = 1,
                    ISBN = "23424234234",
                    Title = "Os cinco",
                    SmallDescription = "historias de aventura com 5 putos",
                    FullDescription = "bla bla bla bla bla bla bla bla bla bla bla bla bla bla",
                    ReleaseDate = "2004",
                    Author = "Na sei",
                    Category = "Aventura, Fantasia",
                },
                new BookDto()
                {
                    Id = 2,
                    ISBN = "564352353",
                    Title = "Os quatro",
                    SmallDescription = "historias de aventura com 4 putos",
                    FullDescription = "bla bla bla bla bla bla bla bla bla bla bla bla bla bla",
                    ReleaseDate = "2005",
                    Author = "Na sei",
                    Category = "Aventura, Fantasia",
                }
            };
        }

    }
}
