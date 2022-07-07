using Application.Common.Repositories;
using Domain.Common;
using Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEditableEntity
    {
        private readonly ProjECommerceDbContext _context;

        public ReadRepository(ProjECommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> condition)
        {
            IList<T> list = await Table.ToListAsync();
            if (condition != null)
            {
                list = await Table.Where(condition).ToListAsync();
            }
            return list;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> condition, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> entity = Table.Where(condition);
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    entity = entity.Include(includeProperty);
                }
            }
            return await entity.SingleOrDefaultAsync();
        }
    }
}
