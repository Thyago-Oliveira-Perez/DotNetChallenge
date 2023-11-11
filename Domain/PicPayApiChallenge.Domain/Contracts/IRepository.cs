namespace PicPayApiChallenge.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity? GetById(Guid id);
        bool Exists(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
