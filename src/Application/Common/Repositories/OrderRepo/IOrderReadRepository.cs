using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Repositories.OrderRepo
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
    }
}
