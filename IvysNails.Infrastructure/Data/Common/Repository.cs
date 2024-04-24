using IvysNails.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace IvysNails.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly IvyNailsDbContext context;

        public Repository(IvyNailsDbContext _context)
        {
            context = _context;    
        }

        private DbSet<T> DbSet<T>() where T : class 
        {
            return context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public Product GetProduct(int productId)
        {
            return context.Products.FirstOrDefault(p => p.Id == productId);
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }
    }
}
