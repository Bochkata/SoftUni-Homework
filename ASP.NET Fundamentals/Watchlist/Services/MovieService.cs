using Microsoft.EntityFrameworkCore;
using Watchlist.Contracts;
using Watchlist.Data;
using Watchlist.Data.Entities;
using Watchlist.Models.Movies;
using static Watchlist.Data.DataConstants.MovieConstants;
using static Watchlist.Data.DataConstants.UserConstants;
namespace Watchlist.Services
{
    public class MovieService : IMovieService
    {
        private readonly WatchlistDbContext _watchlistDbContext;

        public MovieService(WatchlistDbContext watchlistDbContext)
        {
            _watchlistDbContext = watchlistDbContext;
        }

        public async Task AddMovieAsync(MovieFormModel movieFormModel)
        {
            Movie movie = new Movie()
            {
                Title = movieFormModel.Title,
                Director = movieFormModel.Director,
                ImageUrl = movieFormModel.ImageUrl,
                GenreId = movieFormModel.GenreId,
                Rating = movieFormModel.Rating
            };
            await _watchlistDbContext.Movies.AddAsync(movie);
            await _watchlistDbContext.SaveChangesAsync();

        }

        public async Task AddMovieToCollection(int movieId, string userId)
        {
            Movie movie = await _watchlistDbContext.Movies.FirstOrDefaultAsync(x => x.Id == movieId);

            if (movie == null)
            {
                throw new ArgumentException(InvalidMovieId);
            }
            User user = await _watchlistDbContext.Users
                .Include(u=>u.UsersMovies)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException(InvalidUserId);

            }
            if (!user.UsersMovies.Any(m => m.MovieId == movieId))
            {
                user.UsersMovies.Add(new UserMovie { UserId = user.Id, MovieId = movie.Id });
                await _watchlistDbContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            return await _watchlistDbContext.Genres.ToListAsync();
        }

        public async Task<MoviesAllViewModel> GetAllMoviesAsync()
        {
            List<Movie> movies = await _watchlistDbContext.Movies.Include(m => m.Genre).ToListAsync();
            return new MoviesAllViewModel()
            {
                Movies = movies.Select(m => new MovieViewModel()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Director = m.Director,
                    Genre = m.Genre?.Name,
                    ImageUrl = m.ImageUrl,
                    Rating = m.Rating,

                })
            };
        }

        public async Task<MoviesAllViewModel> Watched(string userId)
        {
            User user = await _watchlistDbContext.Users
                .Include(u => u.UsersMovies)
                .ThenInclude(um => um.Movie)
                .ThenInclude(um => um.Genre)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException(InvalidUserId);
            }


            return new MoviesAllViewModel()
            {
                Movies = user.UsersMovies.Select(um => new MovieViewModel()
                {
                    Id = um.Movie.Id,
                    Title = um.Movie.Title,
                    Director = um.Movie.Director,
                    ImageUrl = um.Movie.ImageUrl,
                    Rating = um.Movie.Rating,
                    Genre = um.Movie.Genre?.Name
                })
            };
        }


        public async Task RemoveMovieFromCollectionAsync(int movieId, string userId)
        {
            User user = await _watchlistDbContext.Users
                .Include(u => u.UsersMovies)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException(InvalidUserId);
            }

            UserMovie movie = user.UsersMovies.FirstOrDefault(um => um.MovieId == movieId);

            if (movie != null)
            {
                user.UsersMovies.Remove(movie);
                await _watchlistDbContext.SaveChangesAsync();
            }
        }

    }
}
