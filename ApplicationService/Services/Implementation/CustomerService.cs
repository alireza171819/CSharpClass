using Model.Domains;
using Model.GenericRepository;
using ApplicationService.Services.Interface;
using ApplicationService.Dtos.Customer;

namespace ApplicationService.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        #region Filds

        private readonly IRepositoryBase<Customer> _repositoryCustomer;

        #endregion

        #region Ctor

        public CustomerService()
        {
            _repositoryCustomer = new RepositoryBase<Customer>();
        }

        #endregion

        #region Methods

        public CreateReturn CreteCustomer(CustomerCreate customerCreate)
        {
            if (customerCreate == null)
            {
                return CreateReturn.NullReference;
            }
            try
            {
                Customer customre = new();
                customre.FirstName = customerCreate.FirstName;
                customre.LastName = customerCreate.LastName;
                customre.DateOfBirth = customerCreate.DateOdBirth;
                _repositoryCustomer.Add(customre);
                return CreateReturn.Success;
            }
            catch (Exception e)
            {
                //Log Exception
                return CreateReturn.Error;
            }
           
        }

        public CustomerInfo GetCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return null;
            }
            CustomerInfo customerInfo = new();
            var customer = _repositoryCustomer.GetId(customerId);
            if (customer is null)
            {
                return null;
            }
            customerInfo.FirstName = customer.FirstName;
            customerInfo.LastName = customer.LastName;
            customerInfo.DateOfBirth = customer.DateOfBirth; 
            return customerInfo;
        }

        public List<CustomerInfo> GetCustomres()
        {
            var customresInfo = new List<CustomerInfo>();
            var customers = _repositoryCustomer.GetList(c => c.IsDeleted == false);
            if (customers == null)
            {
                return null;
            }
            foreach (var item in customers)
            {
                var customerInfo = new CustomerInfo();
                customerInfo.FirstName = item.FirstName;
                customerInfo.LastName = item.LastName;
                customerInfo.DateOfBirth= item.DateOfBirth;
                customresInfo.Add(customerInfo);
            }
            return customresInfo;
        }

        public RemoveReturn RemoveCustomer(CustomerRemove customerRemove)
        {
            try
            {
                var customer = _repositoryCustomer.GetId(customerRemove.Id);
                if (customer == null)
                {
                    return RemoveReturn.NotFound;
                }
                customer.UpdateDate = DateTime.Now;
                customer.IsDeleted = true;
                _repositoryCustomer.Update(customer);
                return RemoveReturn.Success;
            }
            catch (Exception exp)
            {
                //Log Exception
                return RemoveReturn.Error;
            }
        }

        public UpdateReturn UpdateCustomer(CustomerUpdate customerUpdate)
        {
            try
            {
                var customer = _repositoryCustomer.GetId(customerUpdate.Id);
                if (customer == null)
                {
                    return UpdateReturn.NotFound;
                }
                customer.UpdateDate = DateTime.Now;
                customer.IsDeleted = customerUpdate.IsDeleted;
                customer.FirstName = customerUpdate.FirstName;
                customer.LastName = customerUpdate.LastName;
                customer.DateOfBirth = customerUpdate.DateOfBirth;
                _repositoryCustomer.Update(customer);
                return UpdateReturn.Success;
            }
            catch (Exception exp)
            {
                //Log Exception
                return UpdateReturn.Error;
            }
           
        }
        #endregion
    }
}
