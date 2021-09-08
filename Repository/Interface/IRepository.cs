using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IRepository<TEntity>: IDisposable 
        where TEntity: class
    {
        IEnumerable<TEntity> All();
    }
}
