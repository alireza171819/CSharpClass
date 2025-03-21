using ApplicationService.Dtos.Product;

namespace ApplicationService.Services.Interface
{
    public interface IProductService
    {
        CreateResult CreateProduct(ProductCreate productCreate);
        UpdateResult UpdateProduct(ProductUpdate productUpdate);
        ProductInfo GetProduct(int productId);
        ProductInfo GetProduct(string sku);
        List<ProductInfo> GetProductList();
        RemoveResult RemoveProduct(ProductRemove productRemove);
    }
}
