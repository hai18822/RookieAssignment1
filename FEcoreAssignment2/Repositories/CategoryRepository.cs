using FEcoreAssignment2.Models;

namespace FEcoreAssignment2.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductManagementContext context) : base(context)
        {
        }
    }
}