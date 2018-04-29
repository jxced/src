using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DJGO.ABPGMEdu.EntityFramework.Repositories
{
    public abstract class ABPGMEduRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPGMEduDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPGMEduRepositoryBase(IDbContextProvider<ABPGMEduDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPGMEduRepositoryBase<TEntity> : ABPGMEduRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPGMEduRepositoryBase(IDbContextProvider<ABPGMEduDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
