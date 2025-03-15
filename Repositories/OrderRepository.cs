using FullstackAPI.Models;

namespace FullstackAPI.Repositories;

public class OrderRepository : IOrderRepository
{
	public Task DeleteAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<Order>> GetAllAsync()
	{
		throw new NotImplementedException();
	}

	public Task<Order?> GetByIdAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task PlaceOrder(Product product, Customer customer)
	{
		throw new NotImplementedException();
	}
}
