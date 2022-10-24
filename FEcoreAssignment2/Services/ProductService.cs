using FEcoreAssignment2.DTOs.Product;
using FEcoreAssignment2.Models;
using FEcoreAssignment2.Repositories;
using FEcoreAssignment2.Services.Interfaces;

namespace FEcoreAssignment2.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        private readonly ICategoryRepository _cateRepo;

        public ProductService(IProductRepository productRepo, ICategoryRepository cateRepo)
        {
            _productRepo = productRepo;
            _cateRepo = cateRepo;
        }

        public AddProductResponse? Add(AddProduct addModel)
        {
            using (var transaction = _productRepo.DatabaseTransaction())
            {
                try
                {
                    var category = _cateRepo.Get(s => s.Id == addModel.CategoryId);

                    if (category != null)
                    {
                        var addProduct = new Product
                        {
                            ProductName = addModel.ProductName,
                            CategoryId = category.Id,
                        };

                        var newProduct = _productRepo.Create(addProduct);
                        _productRepo.SaveChange();

                        transaction.Commit();

                        return new AddProductResponse
                        {
                            ProductId = newProduct.Id,
                            ProductName = newProduct.ProductName,
                            CategoryId = newProduct.CategoryId
                        };
                    }

                    return null;
                }
                catch (System.Exception)
                {
                    transaction.RollBack();
                    return null;
                }
            }
        }
    }
}