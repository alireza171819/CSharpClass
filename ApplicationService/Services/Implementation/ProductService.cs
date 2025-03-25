using ApplicationService.Dtos.Product;
using ApplicationService.Services.Interface;
using Model.Domains;
using Model.Dtos;
using Model.GenericRepository.Interface;

namespace ApplicationService.Services.Implementation
{
    public class ProductService : IProductService
    {
        #region Filds

        private readonly IRepositoryBase<Product> _repository;

        #endregion

        #region Ctor

        public ProductService(IRepositoryBase<Product> repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public CreateResult CreateProduct(ProductCreate productCreate)
        {
            if (productCreate == null)
            {
                return CreateResult.NullReference;
            }
            try
            {
                Product product = new();
                product.CreateDate = DateTime.Now;
                product.Title = productCreate.Title;
                product.Description = productCreate.Description;
                product.Sku = productCreate.Sku;
                product.UnitPrice = productCreate.UnitPrice;
                product.UpdateDate = DateTime.Now;
                var result = _repository.Add(product);
                switch (result)
                {
                    case ReturnRepository.Success:
                        return CreateResult.Success;
                    case ReturnRepository.Error:
                        return CreateResult.Error;
                    case ReturnRepository.NullReference:
                        return CreateResult.NullReference;
                }
                return CreateResult.Success;
            }
            catch (Exception e)
            {
                //Log Exception
                return CreateResult.Error;
            }
        }

        public ProductInfo GetProduct(int productId)
        {
            if (productId <= 0)
            {
                return null;
            }

            ProductInfo productInfo = new();
            var product = _repository.GetId(productId);
            if (product is null)
            {
                return null;
            }
            productInfo.Title = product.Title;
            productInfo.Description = product.Description;
            productInfo.Sku = product.Sku;
            productInfo.UnitPrice = product.UnitPrice;
            return productInfo;
        }

        public ProductInfo GetProduct(string sku)
        {
            throw new NotImplementedException();
        }

        public List<ProductInfo> GetProductList()
        {
            try
            {
                var productsInfo = new List<ProductInfo>();
                var products = _repository.GetList(p => p.IsDeleted == false);
                if (products == null)
                {
                    return null;
                }
                foreach (var product in products)
                {
                    var productInfo = new ProductInfo();
                    productInfo.Id = product.Id;
                    productInfo.Title = product.Title;
                    productInfo.Description = product.Description;
                    productInfo.Sku = product.Sku;
                    productInfo.UnitPrice = product.UnitPrice;
                    productsInfo.Add(productInfo);
                }
                return productsInfo;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RemoveResult RemoveProduct(ProductRemove productRemove)
        {
            if (productRemove == null)
            {
                return RemoveResult.NullReference;
            }
            try
            {
                var product = _repository.GetId(productRemove.Id);
                if (product == null)
                {
                    return RemoveResult.NotFound;
                }
                product.IsDeleted = true;
                product.UpdateDate = DateTime.Now;
                var result = _repository.Update(product);
                switch (result)
                {
                    case ReturnRepository.Success:
                        return RemoveResult.Success;
                    case ReturnRepository.Error:
                        return RemoveResult.Error;
                    case ReturnRepository.NullReference:
                        return RemoveResult.NullReference;
                    case ReturnRepository.NotFound:
                        return RemoveResult.NotFound;
                }
                return RemoveResult.Success;
            }
            catch (Exception e)
            {
                return RemoveResult.Error;
            }
        }

        public UpdateResult UpdateProduct(ProductUpdate productUpdate)
        {
            if (productUpdate == null)
            {
                return UpdateResult.NullReference;
            }
            try
            {
                var product = _repository.GetId(productUpdate.Id);
                if (product == null)
                {
                    return UpdateResult.NotFound;
                }
                product.UpdateDate = DateTime.Now;
                product.Title = productUpdate.Title;
                product.Description = productUpdate.Description;
                product.Sku = productUpdate.Sku;
                product.UnitPrice = productUpdate.UnitPrice;
                var result = _repository.Update(product);
                switch (result)
                {
                    case ReturnRepository.Success:
                        return UpdateResult.Success;
                    case ReturnRepository.Error:
                        return UpdateResult.Error;
                    case ReturnRepository.NullReference:
                        return UpdateResult.NullReference;
                    case ReturnRepository.NotFound:
                        return UpdateResult.NotFound;
                }
                return UpdateResult.Success;
            }
            catch (Exception e)
            {
                return UpdateResult.Error;
            }
        }

        #endregion
    }
}
