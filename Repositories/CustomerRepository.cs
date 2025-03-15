using FullstackAPI.Data;
using FullstackAPI.Models;

namespace FullstackAPI.Repositories;

public class CustomerRepository : ICustomerRepository
{
	private readonly StoreContext _dbContext;
	public Task AddAsync(Customer customer)
	{
		throw new NotImplementedException();
	}

	public Task DeleteAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<Customer>> GetAllAsync()
	{
		throw new NotImplementedException();
	}

	public Task<Customer?> GetByIdAsync(int id)
	{
		throw new NotImplementedException();
	}

	public Task<Product?> GetByEmailAsync(string email)
	{
		throw new NotImplementedException();
	}

	public Task UpdateAsync(Customer customer)
	{
		throw new NotImplementedException();
	}
}
