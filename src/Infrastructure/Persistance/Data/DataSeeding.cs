using Domain.Entities;
using Infrastructure.Persistance.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Data
{
    public class DataSeeding
    {
        private readonly ProjECommerceDbContext _context;

        public DataSeeding(ProjECommerceDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Categories.Any())
            {
                var categories = new List<Category>()
                {
                        new Category()
                        {
                            Id=Guid.NewGuid().ToString(),
                            Name = "Mavi",
                            CreatedDate=DateTime.Now,
                        },
                        new Category()
                        {
                            Id=Guid.NewGuid().ToString(),
                            Name = "Kırmızı",
                            CreatedDate=DateTime.Now,
                        }
                };

                _context.Categories.AddRange(categories);
                _context.SaveChanges();
            }
        }
    }
}
