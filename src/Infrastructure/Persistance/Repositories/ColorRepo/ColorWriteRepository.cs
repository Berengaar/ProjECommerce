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
    public class ColorWriteRepository : WriteRepository<Color>, IColorWriteRepository
    {
        public ColorWriteRepository(ProjECommerceDbContext context) : base(context)
        {
        }
    }
}
