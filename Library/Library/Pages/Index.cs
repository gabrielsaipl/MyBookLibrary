using Library.Books;
using System.Data.Entity;
//code moved from the book overview.cs to here for better performance
namespace Library.Pages
{
    public partial class Index
    {
        public IEnumerable<Book> Books { get; set; }
        //initialize database and books asynchronously
        protected override Task OnInitializedAsync()
        {
            
            //var db = new BookDb();


            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookDb>());
            //InitializaBooks();

            return base.OnInitializedAsync();
        }
        //10 initial books
        private void InitializaBooks()
        {
            //creating a new database instance
            var db = new BookDb();
            //db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Books]");

            //check if there are any books
            /*if (!db.Books.Any())
            {
                var b1 = new Book
            
                {
                Title = "The Alchemist",
                Description = "A fable about following your dreams.",
                ReleaseDate = "1988",
                ISBN = "0061122416",
                Category = "Fiction, Fantasy"
            };

            var b2 = new Book
            {
                Title = "1984",
                Description = "Dystopian novel by George Orwell about totalitarianism and repression of individuality.",
                ReleaseDate = "1949",
                ISBN = "0451524934",
                Category = "Fiction, Dystopia"
            };

            var b3 = new Book
            {
                Title = "To Kill a Mockingbird",
                Description = "Semi-autobiographical novel by Harper Lee about racism and injustice in the American South.",
                ReleaseDate = "1960",
                ISBN = "0446310786",
                Category = "Fiction, Drama"
            };

            var b4 = new Book
            {
                Title = "The Handmaid's Tale",
                Description = "Dystopian novel by Margaret Atwood depicting a totalitarian future where women are property of the state.",
                ReleaseDate = "1985",
                ISBN = "038549081X",
                Category = "Fiction, Dystopia"
            };

            var b5 = new Book
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                Description = "First novel in the popular fantasy series about an orphan boy who discovers he is a wizard.",
                ReleaseDate = "1997",
                ISBN = "059035342X",
                Category = "Fiction, Fantasy"
            };

            var b6 = new Book
            {
                Title = "Pride and Prejudice",
                Description = "Novel by Jane Austen about the relationship between Elizabeth Bennet and Mr. Darcy in early 19th-century England.",
                ReleaseDate = "1813",
                ISBN = "0141439513",
                Category = "Fiction, Romance"
            };

            var b7 = new Book
            {
                Title = "Fahrenheit 451",
                Description = "Dystopian novel by Ray Bradbury about censorship, mass media, and the importance of literature.",
                ReleaseDate = "1953",
                ISBN = "0345410017",
                Category = "Fiction, Dystopia"
            };

            var b8 = new Book
            {
                Title = "Animal Farm",
                Description = "Allegorical novel by George Orwell depicting a group of farm animals rebelling against their human owners to form a commune, which then descends into a totalitarian dictatorship.",
                ReleaseDate = "1945",
                ISBN = "0451526341",
                Category = "Fiction, Allegory"
            };

            var b9 = new Book
            {
                Title = "The Catcher in the Rye",
                Description = "Novel by J. D. Salinger about the alienation, angst, and rebellion of a disaffected teenager in post-World War II United States.",
                ReleaseDate = "1951",
                ISBN = "0316769177",
                Category = "Fiction, Drama"
            };

            var b10 = new Book
            {
                Title = "The Great Gatsby",
                Description = "Novel by F. Scott Fitzgerald depicting the lavish lives of wealthy New Yorkers in the Roaring Twenties.",
                ReleaseDate = "1925",
                ISBN = "0743273567",
                Category = "Fiction, Drama"
            };
                // create a List 
                // inserting it in the database if its empty
                Books = new List<Book> { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 };
            
                foreach (var book in Books)
                {
                    db.Books.Add(book);
                }
                db.SaveChanges();
            }
*/
        }
    }
}
