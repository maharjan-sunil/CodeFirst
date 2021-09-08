using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository.Implementations
{
    public class RepositoryBase<TEntity, T> : IRepository<TEntity>
        where TEntity : class
        where T : DbContext
    {
        #region 
        internal T context;
        private readonly DbSet<TEntity> _dbSet;
        private const bool ShareContext = false;
        #endregion

        public RepositoryBase(T context)
        {
            this.context = context;
            _dbSet = context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }
        public IEnumerable<TEntity> All()
        {
            return DbSet.AsEnumerable<TEntity>().ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
