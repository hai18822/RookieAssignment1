using FEcoreAssignment2.Models;

namespace FEcoreAssignment2.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductManagementContext context) : base(context)
        {
        }
    }
}