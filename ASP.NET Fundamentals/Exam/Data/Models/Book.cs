using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using static Library.Data.Const.Book;


namespace Library.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleBookMaxLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(AuthorBookMaxLength)]
        public string Author { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(DescriptionBookMaxLength)]
        public string Description { get; set; }

        [Required]
        [Range(typeof(decimal), RatingBookMinRate,RatingBookMaxRate, ConvertValueInInvariantCulture = true)]
        public decimal Rating { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public List<ApplicationUserBook> ApplicationUsersBooks { get; set; } = new List<ApplicationUserBook>();



    }
}
