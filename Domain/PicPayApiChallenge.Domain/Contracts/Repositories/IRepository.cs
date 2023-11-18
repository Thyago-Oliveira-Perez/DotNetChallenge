namespace PicPayApiChallenge.Domain.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetById(Guid id);
        Task<bool> Exists(Guid id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);
    }
}
