using Application.Common.Repositories.ColorRepo;
using Domain.Entities;
using Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repositories.ColorRepo
{
    public class ColorReadRepository : ReadRepository<Color>, IColorReadRepository
    {
        public ColorReadRepository(ProjECommerceDbContext context) : base(context)
        {
        }
    }
}
