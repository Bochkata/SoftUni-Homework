using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watchlist.Data.Entities
{
    public class UserMovie
    {
        [ForeignKey(nameof(User))]
        [Required]
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        [ForeignKey(nameof(Movie))]
        [Required]
        public int MovieId { get; set; }

        public Movie Movie { get; set; } = null!;

    }


}