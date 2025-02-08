using Microsoft.EntityFrameworkCore;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
{

    protected readonly VestibularContext Db;
    protected readonly DbSet<TEntity> DbSet;

    protected BaseRepository(VestibularContext db)
    {
        Db = db;
        DbSet = db.Set<TEntity>();

    }

    public TEntity Create(TEntity entity)
    {
        DbSet.Add(entity);

        Db.SaveChanges();

        return entity;
    }

    public bool Delete(Guid id)
    {
        if(Exists(id)){
            
            TEntity entity = DbSet.Where(e => e.Id == id).FirstOrDefault() ?? new TEntity();

            DbSet.Remove(entity);

            Db.SaveChanges();

            return true;
        }
        
        return false;
    }

    public void Dispose()
    {
        Db?.Dispose();
    }

    public bool Exists(Guid id)
    {
        return DbSet.Where(e => e.Id == id).FirstOrDefault() != null;
    }

    public IEnumerable<TEntity> FindAll()
    {
        return DbSet.ToList();
    }

    public TEntity? FindById(Guid id)
    {
        TEntity entityAux = new TEntity();

        TEntity entity = DbSet.Where(e => e.Id == id).FirstOrDefault() ?? entityAux;

        return entity.Id == entityAux.Id ? null : entity;
    }

    public TEntity Update(TEntity entity)
    {
        DbSet.Update(entity);

        Db.SaveChanges();

        return entity;
    }
}