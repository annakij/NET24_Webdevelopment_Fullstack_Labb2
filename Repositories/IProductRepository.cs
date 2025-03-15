using FullstackAPI.Models;

namespace FullstackAPI.Repositories;

public interface IProductRepository
{
	Task<IEnumerable<Product>> GetAllAsync();
	Task<Product?> GetByIdAsync(int id);
	Task<Product?> GetByNameAsync(string name);
	Task AddAsync(Product product);
	Task UpdateAsync(Product product);
	Task DeleteAsync(int id);
}

  