using WebApplication1.DTOs;

namespace WebApplication1.Services
{
    public interface IRentalService
    {
        Task<CustomerRentalsDTO> GetCustomerRentalsAsync(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
