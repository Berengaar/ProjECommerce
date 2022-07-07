using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEditableEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(IList<T> entities);
        Task<bool> UpdateAsync(T entity);
        Task<bool> RemoveAsync(T entity, Expression<Func<T, bool>> condition = null);
    }
}
