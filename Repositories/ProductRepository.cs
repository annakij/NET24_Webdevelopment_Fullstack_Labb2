using FullstackAPI.Data;
using FullstackAPI.Models;

namespace FullstackAPI.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly StoreContext _dbContext;

		public Task<IEnumerable<Product>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Product?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Product?> GetByNameAsync(string name)
		{
			throw new NotImplementedException();
		}

		public Task AddAsync(Product product)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Product product)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
