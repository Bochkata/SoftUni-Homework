using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Watchlist.Data.DataConstants.MovieConstants;


namespace Watchlist.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DirectorNameMaxLength)]
        public string Director { get; set; } = null!;


        [Required]
       public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        [ForeignKey(nameof(Genre))]
        public int? GenreId { get; set; }

        public Genre? Genre { get; set; }

        public List<UserMovie> UsersMovies = new List<UserMovie>();
    }

}