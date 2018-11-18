using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class Repository : IDisposable, IRepository
    {
        #region declarations

        private DB_Gestion_TurnosEntities _db;

        #endregion declarations

        #region constructor

        public Repository(DB_Gestion_TurnosEntities db)
        {
            this._db = db;
        }

        #endregion constructor

        #region methods

        public bool create<TEntity>(TEntity toCreate) where TEntity : class
        {
            try
            {
                _db.Set<TEntity>().Add(toCreate);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete<TEntity>(TEntity toDelete) where TEntity : class
        {
            try
            {
                _db.Entry<TEntity>(toDelete).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }

        public List<TEntities> GetAll<TEntities>(Expression<Func<TEntities, bool>> condition = null) where TEntities : class
        {
            if (condition != null)
            {
                return _db.Set<TEntities>().Where(condition).ToList();
            }
            return _db.Set<TEntities>().ToList();
        }

        public TEntities retrieve<TEntities>(Expression<Func<TEntities, bool>> condition) where TEntities : class
        {
            return _db.Set<TEntities>().FirstOrDefault(condition);
        }

        public int Count<TEntities>(Func<TEntities, int> columnSelector) where TEntities : class
        {
            var GetMaxId = _db.Set<TEntities>().Max(columnSelector);
            return GetMaxId > 0 ? GetMaxId : 0;
        }

        public bool update<TEntity>(TEntity toUpdate) where TEntity : class
        {
            try
            {
                _db.Entry<TEntity>(toUpdate).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion methods
    }
}