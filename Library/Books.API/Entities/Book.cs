using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.API.Entities
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
