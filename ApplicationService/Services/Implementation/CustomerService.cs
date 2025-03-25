using Model.Domains;
using ApplicationService.Services.Interface;
using ApplicationService.Dtos.Customer;
using Model.Dtos;
using Model.GenericRepository.Interface;

namespace ApplicationService.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        #region Filds

        private readonly IRepositoryBase<Customer> _repository;

        #endregion

        #region Ctor

        public CustomerService(IRepositoryBase<Customer> repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public CreateResult CreateCustomer(CustomerCreate customerCreate)
        {
            if (customerCreate == null)
            {
                return CreateResult.NullReference;
            }
            try
            {
                Customer customre = new();
                customre.FirstName = customerCreate.FirstName;
                customre.LastName = customerCreate.LastName;
                customre.DateOfBirth = customerCreate.DateOfBirth;
                customre.CreateDate = DateTime.Now;
                customre.UpdateDate = DateTime.Now;
                var result = _repository.Add(customre);
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

        public CustomerInfo GetCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return null;
            }
            CustomerInfo customerInfo = new();
            var customer = _repository.GetId(customerId);
            if (customer is null)
            {
                return null;
            }
            customerInfo.FirstName = customer.FirstName;
            customerInfo.LastName = customer.LastName;
            customerInfo.DateOfBirth = customer.DateOfBirth; 
            return customerInfo;
        }

        public List<CustomerInfo> GetCustomreList()
        {
            var customresInfo = new List<CustomerInfo>();
            var customers = _repository.GetList(c => c.IsDeleted == false);
            if (customers == null)
            {
                return null;
            }
            foreach (var item in customers)
            {
                CustomerInfo customerInfo = new();
                customerInfo.Id = item.Id;
                customerInfo.FirstName = item.FirstName;
                customerInfo.LastName = item.LastName;
                customerInfo.DateOfBirth= item.DateOfBirth;
                customresInfo.Add(customerInfo);
            }
            return customresInfo;
        }

        public RemoveResult RemoveCustomer(CustomerRemove customerRemove)
        {
            if (customerRemove == null)
            {
                return RemoveResult.NullReference;
            }
            try
            {
                var customer = _repository.GetId(customerRemove.Id);
                if (customer == null)
                {
                    return RemoveResult.NotFound;
                }
                customer.UpdateDate = DateTime.Now;
                customer.IsDeleted = true;
                var result = _repository.Update(customer);
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
            catch (Exception exp)
            {
                //Log Exception
                return RemoveResult.Error;
            }
        }

        public UpdateResult UpdateCustomer(CustomerUpdate customerUpdate)
        {
            if (customerUpdate == null)
            {
                return UpdateResult.NullReference;
            }
            try
            {
                var customer = _repository.GetId(customerUpdate.Id);
                if (customer == null)
                {
                    return UpdateResult.NotFound;
                }
                customer.UpdateDate = DateTime.Now;
                customer.FirstName = customerUpdate.FirstName;
                customer.LastName = customerUpdate.LastName;
                customer.DateOfBirth = customerUpdate.DateOfBirth;
                var result = _repository.Update(customer);
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
            catch (Exception exp)
            {
                //Log Exception
                return UpdateResult.Error;
            }
        }
        #endregion
    }
}
