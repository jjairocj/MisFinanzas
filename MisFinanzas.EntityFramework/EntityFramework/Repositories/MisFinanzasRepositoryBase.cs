using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MisFinanzas.EntityFramework.Repositories
{
    public abstract class MisFinanzasRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MisFinanzasDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MisFinanzasRepositoryBase(IDbContextProvider<MisFinanzasDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MisFinanzasRepositoryBase<TEntity> : MisFinanzasRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MisFinanzasRepositoryBase(IDbContextProvider<MisFinanzasDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
