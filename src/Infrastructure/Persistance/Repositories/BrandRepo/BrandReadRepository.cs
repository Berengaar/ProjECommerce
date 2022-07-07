using Application.Common.Repositories.BrandRepo;
using Domain.Entities;
using Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repositories.BrandRepo
{
    public class BrandReadRepository : ReadRepository<Brand>, IBrandReadRepository
    {
        public BrandReadRepository(ProjECommerceDbContext context) : base(context)
        {
        }
    }
}
