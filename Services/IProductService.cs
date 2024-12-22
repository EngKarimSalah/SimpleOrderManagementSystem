using SimpleOrderManagementSystem.DTOs;

namespace SimpleOrderManagementSystem.Services
{
    public interface IProductService
    {
        int AddProduct(ProductInputDTO input);
    }
}