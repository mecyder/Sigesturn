using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL
{
    public interface IRepository : IDisposable
    {
        bool create<TEntity>(TEntity toCreate) where TEntity : class;

        bool delete<TEntity>(TEntity toDelete) where TEntity : class;

        bool update<TEntity>(TEntity toUpdate) where TEntity : class;

        TEntities retrieve<TEntities>(Expression<Func<TEntities, bool>> condition) where TEntities : class;

        List<TEntities> GetAll<TEntities>(Expression<Func<TEntities, bool>> condition = null) where TEntities : class;

        int Count<TEntities>(Func<TEntities, int> columnSelector) where TEntities : class;
    }
}