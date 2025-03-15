using FullstackAPI.Models;

namespace FullstackAPI.Repositories;

public interface ICustomerRepository
{
	Task<IEnumerable<Customer>> GetAllAsync();
	Task<Customer?> GetByIdAsync(int id);
	Task<Product?> GetByEmailAsync(string email);
	Task AddAsync(Customer customer);
	Task UpdateAsync(Customer customer);
	Task DeleteAsync(int id);

}