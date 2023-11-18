using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Domain.Contracts.Repositories;

namespace PicPayApiChallenge.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected DbSet<TEntity> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity?> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> Exists(Guid id)
        {
            return await GetById(id) != null;
        }

        public async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
