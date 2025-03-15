using FullstackAPI.Models;

namespace FullstackAPI.Repositories;

public interface IOrderRepository
{
	Task<IEnumerable<Order>> GetAllAsync();
	Task<Order?> GetByIdAsync(int id);
	Task PlaceOrder(Product product, Customer customer);
	Task DeleteAsync(int id);
}
