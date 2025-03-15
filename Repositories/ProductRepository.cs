using FullstackAPI.Data;
using FullstackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FullstackAPI.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly StoreContext _dbContext;

		public ProductRepository(StoreContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			return await _dbContext.Products.ToListAsync();
		}
		public async Task<Product?> GetByIdAsync(int id)
		{
			var product = await _dbContext.Products.FindAsync(id);
			return product;
		}
		public async Task<Product?> GetByNameAsync(string name)
		{
			var product = await _dbContext.Products.FindAsync(name);
			return product;
		}
		public async Task AddAsync(Product product)
		{
			_dbContext.Products.Add(product); 
			await _dbContext.SaveChangesAsync();
		}
		public async Task UpdateAsync(Product product)
		{
			_dbContext.Update(product);
			await _dbContext.SaveChangesAsync();
		}
		public async Task DeleteAsync(int id)
		{
			_dbContext.Remove(id);
			await _dbContext.SaveChangesAsync();
		}
	}
}
