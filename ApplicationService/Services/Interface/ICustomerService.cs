using ApplicationService.Dtos.Customer;
using System.Globalization;

namespace ApplicationService.Services.Interface
{
    public interface ICustomerService
    {
        CreateReturn CreteCustomer(CustomerCreate customer);
        UpdateReturn UpdateCustomer(CustomerUpdate customer);
        CustomerInfo GetCustomer(int customerId);
        List<CustomerInfo> GetCustomres();
        RemoveReturn RemoveCustomer(CustomerRemove customer);
    }
}
