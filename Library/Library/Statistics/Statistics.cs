using Library.Books;

namespace Library.Statistics
{
    public class Statistics
    {
        //initialize query variable
        private List<Book> query = new List<Book>();


        public int TotalNumberBooks()
        {
            var db = new BookDb();
            var count = db.Books.Count(b => b.Id > 0);

            return count;
        }

        public int TotalNumberRomanceBooks()
        {
            var db = new BookDb();
            var count = db.Books.Count(b => b.Category.Contains("Romance") || b.Category.Contains("romance"));
            return count;
        }

        public int TotalNumberFantasyBooks()
        {
            var db = new BookDb();
            var count = db.Books.Count(b => b.Category.Contains("Fantasy") || b.Category.Contains("fantasy"));
            return count;
        }
    }
}
