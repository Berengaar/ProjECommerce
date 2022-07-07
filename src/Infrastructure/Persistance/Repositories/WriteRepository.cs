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
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEditableEntity
    {
        private readonly ProjECommerceDbContext _context;

        public WriteRepository(ProjECommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            if (entity != null)
            {
                await Table.AddAsync(entity);
                return true;
            }
            return false;
        }

        public async Task<bool> AddRangeAsync(IList<T> entities)
        {
            if (entities.Any())
            {
                await Table.AddRangeAsync(entities);
                return true;
            }
            return false;
        }

        public async Task<bool> RemoveAsync(T entity, Expression<Func<T, bool>> condition = null)
        {
            if (entity != null)
            {
                if (condition != null)
                {
                    entity=await Table.SingleOrDefaultAsync(condition);
                }
                await Task.Run(() => Table.Remove(entity));
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            if (entity!=null)
            {
                await Task.Run(() => Table.Update(entity));
                return true;
            }
            return false;
        }
    }
}
