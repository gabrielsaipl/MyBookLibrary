using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Library.Books
{
    public class Book
    {
        //initial properties for each book
        //the idea is to add other details such as covers, complete descriptions, authors... for the bookdetails
        //Also add a category for each book
        public int Id { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "ISBN is too long.")]
        public string ISBN { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Date is too long.")]
        public string ReleaseDate { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Category is too long.")]
        public string Category { get; set; }

    }
}
