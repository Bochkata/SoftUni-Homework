using Library.Data.Models;
using Library.Models;

namespace Library.Contracts
{
    public interface IBook
    {
        Task<IEnumerable<BookViewModel>> GetAllAsync();

        Task<IEnumerable<Category>> GetCategoryAsync();

        Task Add(AddBookViewModel model);

        Task AddBookToCollectionAsync(int bookId, string userId);

        Task<IEnumerable<BookViewModel>> GetMyBooksAsync(string userId);

        Task RemoveBookFromCollectionAsync(int bookId, string userId);
    }
}
