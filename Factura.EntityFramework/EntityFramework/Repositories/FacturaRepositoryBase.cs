using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace FacturaApp.EntityFramework.Repositories
{
    public abstract class FacturaAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FacturaAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FacturaAppRepositoryBase(IDbContextProvider<FacturaAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FacturaAppRepositoryBase<TEntity> : FacturaAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FacturaAppRepositoryBase(IDbContextProvider<FacturaAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
