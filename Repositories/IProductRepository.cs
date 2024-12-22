using SimpleOrderManagementSystem.Models;

namespace SimpleOrderManagementSystem.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(Product product);
    }
}