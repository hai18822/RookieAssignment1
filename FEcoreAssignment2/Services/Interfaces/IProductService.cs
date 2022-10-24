using FEcoreAssignment2.DTOs.Product;

namespace FEcoreAssignment2.Services.Interfaces
{
    public interface IProductService
    {
        AddProductResponse? Add(AddProduct addModel);
    }
}