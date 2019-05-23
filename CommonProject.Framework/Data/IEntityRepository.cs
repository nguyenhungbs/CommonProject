using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject.Framework.Data
{
    public interface IEntityRepository<T, TC> where T : class, new()
       where TC : DbContext
    {
        TC GetDbContext();

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        T FirstOrDefault(Expression<Func<T, bool>> query);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> query);

        List<T> Fetch();

        Task<List<T>> FetchAsync();

        List<T> Fetch(Expression<Func<T, bool>> query);

        Task<List<T>> FetchAsync(Expression<Func<T, bool>> query);
       
        bool Insert(T data);

        Task<bool> InsertAsync(T data);

        bool Update(T entity);

        Task<bool> UpdateAsync(T entity);

        bool UpdateMany(IEnumerable<T> items);

        Task<bool> UpdateManyAsync(IEnumerable<T> items);

        bool Delete(T entity);

        Task<bool> DeleteAsync(T entity);

        int DeleteMany(Expression<Func<T, bool>> expression);

        Task<int> DeleteManyAsync(Expression<Func<T, bool>> expression);


    }
}
