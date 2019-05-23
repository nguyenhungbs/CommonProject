using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject.Framework.Data
{

    public class EntityRepository<T, TC> : IEntityRepository<T, TC>
       where T : class, new()
       where TC : DbContext, new()
    {

     
        public TC GetDbContext()
        {
            TC db = new TC();
            return db;
        }

        public T GetById(object id)
        {
            using (var context = new TC())
            {
                return context.Set<T>().Find(id);
            }
        }

        public async Task<T> GetByIdAsync(object id)
        {
            using (var context = new TC())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }      
      
        public T FirstOrDefault(Expression<Func<T, bool>> query)
        {
            using (var db = new TC())
            {
                return db.Set<T>().FirstOrDefault(query);
            }
        }
        
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> query)
        {
            using (var context = new TC())
            {
                return await context.Set<T>().FirstOrDefaultAsync(query);
            }
        }

        public bool Insert(T entity)
        {
            using (var db = new TC())
            {
                db.Set<T>().Add(entity);
                var res = db.SaveChanges();
                if (res > 0)
                    return true;
                return false;
            }
        }

        public async Task<bool> InsertAsync(T entity)
        {
            using (var context = new TC())
            {
                context.Set<T>().Add(entity);
                var res = await context.SaveChangesAsync();
                if (res > 0)
                    return true;
                return false;
            }
        }

        public Task<T> FetchAsync(Expression expression)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            using (var db = new TC())
            {
                db.Set<T>().Attach(entity);

                db.Entry<T>(entity).State = EntityState.Modified;

                var res = db.SaveChanges();
                if (res > 0)
                    return true;

                return false;
            }//using
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            using (var context = new TC())
            {
                context.Set<T>().Attach(entity);
                context.Entry<T>(entity).State = EntityState.Modified;

                var res = await context.SaveChangesAsync();
                if (res > 0)
                    return true;
                return false;
            }
        }
       
        public bool UpdateMany(IEnumerable<T> items)
        {
            using (var db = new TC())
            {
                foreach (T item in items)
                {
                    db.Set<T>().Attach(item);
                    db.Entry<T>(item).State = EntityState.Modified;
                }

                var res = db.SaveChanges();
                if (res > 0)
                    return true;
                return false;
            }//using
        }

        public async Task<bool> UpdateManyAsync(IEnumerable<T> items)
        {
            using (var context = new TC())
            {
                foreach (T item in items)
                {
                    context.Set<T>().Attach(item);
                    context.Entry<T>(item).State = EntityState.Modified;
                }

                var res = await context.SaveChangesAsync();
                if (res > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(T entity)
        {
            using (var db = new TC())
            {
                db.Set<T>().Remove(entity);
                var res = db.SaveChanges();
                if (res > 0)
                    return true;
                return false;
            }
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            using (var context = new TC())
            {
                context.Set<T>().Remove(entity);
                var res = await context.SaveChangesAsync();
                if (res > 0)
                    return true;
                return false;
            }
        }

        

        public int DeleteMany(Expression<Func<T, bool>> expression)
        {
            using (var db = new TC())
            {
                IQueryable<T> result = db.Set<T>().Where(expression);

                foreach (T item in result)
                {
                    db.Set<T>().Remove(item);
                }

                var res = db.SaveChanges();
                return res;
            }//using
        }

        public async Task<int> DeleteManyAsync(Expression<Func<T, bool>> expression)
        {
            using (var context = new TC())
            {
                IQueryable<T> result = context.Set<T>().Where(expression);

                foreach (T item in result)
                {
                    context.Set<T>().Remove(item);
                }

                var res = await context.SaveChangesAsync();
                return res;
            }
        }

        public List<T> Fetch()
        {
            using (var db = new TC())
            {
                List<T> result = db.Set<T>().ToList();

                return result;
            }//using
        }

        public async Task<List<T>> FetchAsync()
        {
            using (var db = new TC())
            {
                List<T> result = await db.Set<T>().ToListAsync();
                return result;
            }
        }

        public List<T> Fetch(Expression<Func<T, bool>> query)
        {
            using (var db = new TC())
            {
                List<T> result = new List<T>();

                if (query != null)
                {
                    result = db.Set<T>().Where(query).ToList();
                }
                else
                {
                    result = db.Set<T>().ToList();
                }

                return result;
            }//using
        }
       
        public async Task<List<T>> FetchAsync(Expression<Func<T, bool>> query)
        {
            using (var db = new TC())
            {
                List<T> result = new List<T>();

                if (query != null)
                {
                    result = await db.Set<T>().Where(query).ToListAsync();
                }
                else
                {
                    result = await db.Set<T>().ToListAsync();
                }

                return result;
            }//using
        }

        
    }
}
