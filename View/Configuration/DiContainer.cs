using ApplicationService.Services.Implementation;
using ApplicationService.Services.Interface;
using Model.Domains;
using Model.GenericRepository.Implementation;
using Model.GenericRepository.Interface;
using Ninject;

namespace View.Configuration
{
    public static class DiContainer
    {
        public static void RegisterServices(IKernel ninjectKernel)
        {
            #region Repositories

            ninjectKernel.Bind<IRepositoryBase<Customer>>().To<RepositoryBase<Customer>>();
            ninjectKernel.Bind<IRepositoryBase<Product>>().To<RepositoryBase<Product>>();

            #endregion

            #region Services

            ninjectKernel.Bind<ICustomerService>().To<CustomerService>();
            ninjectKernel.Bind<IProductService>().To<ProductService>();

            #endregion
        }
    }
}
