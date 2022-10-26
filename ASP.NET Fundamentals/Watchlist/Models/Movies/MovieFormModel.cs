using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Watchlist.Data.Entities;
using static Watchlist.Data.DataConstants.MovieConstants;

namespace Watchlist.Models.Movies
{
    public class MovieFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DirectorNameMaxLength, MinimumLength = DirectorNameMinLength)]
        public string Director { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName = RatingDecimal)]
        [Range(typeof(decimal), RatingMin, RatingMax, ConvertValueInInvariantCulture = true)]
        public decimal Rating { get; set; }


        public int GenreId { get; set; }


        public IEnumerable<Genre> Genres = new List<Genre>();
    }
}
