using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEditableEntity
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> condition);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> condition, params Expression<Func<T, object>>[] includeProperties);
    }
}
