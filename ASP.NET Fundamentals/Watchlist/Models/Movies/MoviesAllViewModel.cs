namespace Watchlist.Models.Movies
{
    public class MoviesAllViewModel
    {
        public IEnumerable<MovieViewModel> Movies { get; set; } = new List<MovieViewModel>();
    }
}
