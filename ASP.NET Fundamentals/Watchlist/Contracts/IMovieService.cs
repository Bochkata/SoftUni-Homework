using Watchlist.Models.Movies;
using Watchlist.Data.Entities;

namespace Watchlist.Contracts
{
    public interface IMovieService
    {
        Task AddMovieAsync(MovieFormModel movieFormModel);

        Task <IEnumerable<Genre>> GetAllGenresAsync();

        //Task<IEnumerable<MovieViewModel>> GetAllMoviesAsync();
        Task<MoviesAllViewModel> GetAllMoviesAsync();

        Task AddMovieToCollection(int movieId, string userId);

        Task <MoviesAllViewModel> Watched(string userId);

        Task RemoveMovieFromCollectionAsync(int movieId, string userId); 
    }
}
