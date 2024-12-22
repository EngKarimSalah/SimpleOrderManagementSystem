using SimpleOrderManagementSystem.DTOs;
using SimpleOrderManagementSystem.Models;
using SimpleOrderManagementSystem.Repositories;

namespace SimpleOrderManagementSystem.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public int AddProduct(ProductInputDTO input)
        {

            var product = new Product
            {

                Name = input.Name,
                Description = input.Description,
                Stock = input.Stock,
                Price = input.Price,
                CreatedAt = DateTime.Now,
            };

            return _repository.AddProduct(product);

        }
    }
}
