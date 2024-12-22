using SimpleOrderManagementSystem.Models;

namespace SimpleOrderManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddProduct(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();
            return product.PId;

        }


    }
}
