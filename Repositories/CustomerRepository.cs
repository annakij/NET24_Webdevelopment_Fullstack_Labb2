using FullstackAPI.Data;
using FullstackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FullstackAPI.Repositories;

public class CustomerRepository : ICustomerRepository
{
	private readonly StoreContext _dbContext;

	public CustomerRepository(StoreContext dbContext)
	{
		_dbContext = dbContext;
	}
	public async Task<IEnumerable<Customer>> GetAllAsync()
	{
		return await _dbContext.Customers.ToListAsync();
	}
	public async Task<Customer?> GetByIdAsync(int id)
	{
		var customer = await _dbContext.Customers.FindAsync(id);
		return customer;
	}
	public async Task<Customer?> GetByEmailAsync(string email)
	{
		var customer = await _dbContext.Customers.FindAsync(email);
		return customer;
	}
	public async Task AddAsync(Customer customer)
	{
		_dbContext.Add(customer);
		await _dbContext.SaveChangesAsync();
	}
	public async Task UpdateAsync(Customer customer)
	{
		_dbContext.Update(customer);
		await _dbContext.SaveChangesAsync();
	}
	public async Task DeleteAsync(int id)
	{
		_dbContext.Remove(id);
		await _dbContext.SaveChangesAsync();
	}
}
