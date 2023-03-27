using System.ComponentModel.DataAnnotations;

namespace Books.API.Models
{
    /// <summary>
    /// A DTO for a Book
    /// </summary>
    public class BookDto
    {
        /// <summary>
        /// the Id of the Book
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the ISBN of the Book
        /// </summary>
        [Required]
        [StringLength(18)]
        public string ISBN { get; set; }
        /// <summary>
        /// the Title of the Book
        /// </summary>
        [Required(ErrorMessage = "You gotta put a title bro.")]
        [StringLength(50)]
        public string Title { get; set; }
        /// <summary>
        /// A small description for the Book
        /// </summary>
        [Required]
        [StringLength(200)]
        public string SmallDescription{ get; set; }
        /// <summary>
        /// A full description of the Book
        /// </summary>
        [Required]
        [StringLength(1000)]
        public string FullDescription { get; set; }
        /// <summary>
        /// The year the Book was released
        /// </summary>
        [Required]
        [StringLength(25)]
        public string ReleaseDate{ get; set; }
        /// <summary>
        /// The author of the Book
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        /// <summary>
        /// The Category(ies) of the Book
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

    }
}
