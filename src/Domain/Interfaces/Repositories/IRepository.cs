using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IRepository<TEntity>  : IDisposable where  TEntity : class
{
    Task InsertAsync(TEntity entity);

    Task DeleteAsync(long id);

    Task UpdateAsync(TEntity entity);

    Task<TEntity> GetByIdAsync(long id);

    Task<IEnumerable<TEntity>> GetAllAsync();
}