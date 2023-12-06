using Bookstore.Web.Models;

namespace Bookstore.Web.Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetAllCategories(string token);
    }
}
