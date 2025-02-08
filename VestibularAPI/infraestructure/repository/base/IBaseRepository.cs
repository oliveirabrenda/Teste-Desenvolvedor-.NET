using VestibularAPI.infraestructure.model;

namespace VestibularAPI.infraestructure.repository;

public interface IBaseRepository<TEntity> : IDisposable where TEntity : BaseEntity{

    IEnumerable<TEntity> FindAll();

    TEntity? FindById(Guid id);

    TEntity Create(TEntity entity);

    TEntity Update(TEntity entity);

    bool Delete(Guid id);

    bool Exists(Guid id);
}