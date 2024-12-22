using SimpleOrderManagementSystem.Models;

namespace SimpleOrderManagementSystem.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(Product product);

        List<Product> GetProducts(decimal? minPrice, decimal? maxPrice, int pageNumber, int pageSize);

    }
}