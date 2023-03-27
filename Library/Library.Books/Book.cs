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
        [StringLength(18)]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "You gotta put a title bro.")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string SmallDescription { get; set; }
        [Required]
        [StringLength(1000)]
        public string FullDescription { get; set; }
        [Required]
        [StringLength(25)]
        public string ReleaseDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

    }
}
