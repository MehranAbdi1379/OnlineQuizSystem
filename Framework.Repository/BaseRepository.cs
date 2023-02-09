using Framework.Core;
using Framework.Core.Repository;

namespace Framework.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly BaseDbContext context;

    public BaseRepository(BaseDbContext context)
    {
        this.context = context;
    }

    //TODO: Solve SaveChange Problem

    public void Create(TEntity entity)
    {
        context.Add(entity);
    }

    public void Delete(TEntity entity)
    {
        context.Remove(entity);
    }

    public void Save()
    {
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        context.Update(entity);
    }
}