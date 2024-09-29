using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Author { get; set; }

        [Required]
        [Range(0, 1000)]
        public decimal Price { get; set; }
    }

}
