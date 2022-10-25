using Library.Contracts;
using Library.Data;
using Library.Data.Models;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookService : IBook
    {
        private readonly LibraryDbContext context;

        public BookService(LibraryDbContext _context)
        {
            context = _context;
        }

        public async Task Add(AddBookViewModel model)
        {
            var entity = new Book()
            {
                Author = model.Author,
                Title = model.Title,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Rating = model.Rating,
                CategoryId = model.CategoryId,
                
            };

            await context.Books.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task AddBookToCollectionAsync(int bookId, string userId)
        {
            var user = await context.Users.
                Include(x => x.ApplicationUsersBooks)
                .FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var book = await context.Books.FirstOrDefaultAsync(u => u.Id == bookId);

            if (book == null)
            {
                throw new ArgumentException("Invalid Movie ID");
            }

            if (!user.ApplicationUsersBooks.Any(b => b.BookId == bookId))
            {
                user.ApplicationUsersBooks.Add(new ApplicationUserBook()
                {
                    BookId = book.Id,
                    ApplicationUserId = user.Id,
                    Book = book,
                    ApplicationUser = user
                });

                await context.SaveChangesAsync();
            }


        }

        public async Task<IEnumerable<BookViewModel>> GetAllAsync()
        {
            var entities = await context.Books
              .Include(b => b.Category)
              .ToListAsync();

            return entities
                .Select(b => new BookViewModel()
                {
                  Author = b.Author,
                  Category = b?.Category?.Name,
                  Id = b.Id,
                  ImageUrl = b.ImageUrl,
                  Rating = b.Rating,
                  Title = b.Title,
                  Description = b.Description,                 
                });
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<BookViewModel>> GetMyBooksAsync(string userId)
        {
            var user = await context.Users
                .Where(u => u.Id == userId).
                Include(a => a.ApplicationUsersBooks).
                ThenInclude(b => b.Book).
                ThenInclude(c => c.Category).
                FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return user.ApplicationUsersBooks
                .Select(b => new BookViewModel()
                {
                    Author = b.Book.Author,
                    Id = b.Book.Id,
                    Category = b.Book.Category?.Name,
                    ImageUrl = b.Book.ImageUrl,
                    Title= b.Book.Title,
                    Rating = b.Book.Rating,
                    Description = b.Book.Description
                }) ;
        }

        public async Task RemoveBookFromCollectionAsync(int bookId, string userId)
        {
            var user = await context.Users
                 .Where(u => u.Id == userId)
                 .Include(u => u.ApplicationUsersBooks)
                 .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var book = user.ApplicationUsersBooks.FirstOrDefault(m => m.BookId == bookId);

            if (book != null)
            {
                user.ApplicationUsersBooks.Remove(book);

                await context.SaveChangesAsync();
            }
        }

       
    }
}
