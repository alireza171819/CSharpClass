using ApplicationService.Dtos.Customer;

namespace ApplicationService.Services.Interface
{
    public interface ICustomerService
    {
        CreateResult CreateCustomer(CustomerCreate customer);
        UpdateResult UpdateCustomer(CustomerUpdate customer);
        CustomerInfo GetCustomer(int customerId);
        List<CustomerInfo> GetCustomreList();
        RemoveResult RemoveCustomer(CustomerRemove customer);
    }
}
